using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace FolderImport
{
    public partial class MainForm : Form
    {
        // Option keys and defaults
        public const string OptionInputFolder = "InputFolder";
        public const string OptionDefaultInputFolder = "%USERPROFILE%\\Documents\\";
        public const string OptionOutputFolder = "OutputFolder";
        public const string OptionDefaultOutputFolder = "%USERPROFILE%\\Desktop\\";
        public const string OptionTemplateFolder = "TemplateFolder";
        public const string OptionDefaultTemplateFolder = "%USERPROFILE%";

        // Option Data File constants
        public const string OptionDataFileDirectory = "%APPDATA%\\FolderImport\\";
        public const string OptionDataFileName = "Options.json";

        private Dictionary<string, object> m_Options;
        private string m_OptionsFilePath;
        
        public MainForm()
        {
            InitializeComponent();
            // Load our options from %APPDATA%
            if(m_Options == null)
            {
                LoadOptions();
            }
            // Set up the folders - Use ToString to prevent errors with malformed JSON
            txtInputFolder.Text = m_Options[OptionInputFolder].ToString();
            txtOutputFolder.Text = m_Options[OptionOutputFolder].ToString();
            txtTemplateFolder.Text = m_Options[OptionTemplateFolder].ToString();
        }

        public object GetOption(string option_name, object default_value)
        {
            object output;
            if (m_Options.TryGetValue(option_name, out output))
            {
                return output;
            }else
            {
                return default_value;
            }
        }
        public void SetOption(string option_name, object value)
        {
            m_Options[option_name] = value;
            string data_out = JsonConvert.SerializeObject(m_Options);
            File.WriteAllText(m_OptionsFilePath, data_out);
        }

        public void LoadOptions()
        {
            string data_path = Environment.ExpandEnvironmentVariables(OptionDataFileDirectory);
            m_OptionsFilePath = Path.Combine(data_path, OptionDataFileName);
            if (File.Exists(m_OptionsFilePath))
            {
                m_Options = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(m_OptionsFilePath));
                // Check that all the options we absolutely need are there
                bool write_options = false;
                if(!m_Options.ContainsKey(OptionInputFolder))
                {
                    m_Options[OptionInputFolder] = Environment.ExpandEnvironmentVariables(OptionDefaultInputFolder);
                    write_options = true;
                }
                if(!m_Options.ContainsKey(OptionOutputFolder))
                {
                    m_Options[OptionOutputFolder] = Environment.ExpandEnvironmentVariables(OptionDefaultOutputFolder);
                    write_options = true;
                }
                if(!m_Options.ContainsKey(OptionTemplateFolder))
                {
                    m_Options[OptionTemplateFolder] = Environment.ExpandEnvironmentVariables(OptionDefaultTemplateFolder);
                    write_options = true;
                }

                if(write_options)
                {
                    File.WriteAllText(m_OptionsFilePath, JsonConvert.SerializeObject(m_Options));
                }
            } else
            {
                if (!Directory.Exists(data_path))
                {
                    Directory.CreateDirectory(data_path);
                }
                m_Options = new Dictionary<string, object>();
                m_Options[OptionInputFolder] = Environment.ExpandEnvironmentVariables(OptionDefaultInputFolder);
                m_Options[OptionOutputFolder] = Environment.ExpandEnvironmentVariables(OptionDefaultOutputFolder);
                m_Options[OptionTemplateFolder] = Environment.ExpandEnvironmentVariables(OptionDefaultTemplateFolder);
                File.WriteAllText(m_OptionsFilePath, JsonConvert.SerializeObject(m_Options));
            }
        }

        private string GetFolder(string start_path, string dialog_text = "Choose a folder")
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (Directory.Exists(start_path))
            {
                fbd.SelectedPath = start_path;
            }
            fbd.Description = dialog_text;
            DialogResult results = fbd.ShowDialog();
            if(results == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                return fbd.SelectedPath;
            }
            return null;
        }

        private void btnInputFolderChoose_Click(object sender, EventArgs e)
        {
            string newfolder = GetFolder(txtInputFolder.Text, "Choose a folder to import from:");
            if(Directory.Exists(newfolder))
            {
                SetOption(OptionInputFolder, newfolder);
                txtInputFolder.Text = newfolder;
            }
        }

        private void btnOutputFolderChoose_Click(object sender, EventArgs e)
        {
            string newfolder = GetFolder(txtOutputFolder.Text, "Choose a folder to output to:");
            if(Directory.Exists(newfolder))
            {
                SetOption(OptionOutputFolder, newfolder);
                txtOutputFolder.Text = newfolder;
            }
        }

        private void btnTemplateFolderChoose_Click(object sender, EventArgs e)
        {
            string newfolder = GetFolder(txtTemplateFolder.Text, "Select the template folder to compare against:");
            if(Directory.Exists(newfolder))
            {
                SetOption(OptionTemplateFolder, newfolder);
                txtTemplateFolder.Text = newfolder;
            }
        }
    }
}
