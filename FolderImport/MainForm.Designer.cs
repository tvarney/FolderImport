namespace FolderImport
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInputFolderChoose = new System.Windows.Forms.Button();
            this.btnOutputFolderChoose = new System.Windows.Forms.Button();
            this.btnTemplateFolderChoose = new System.Windows.Forms.Button();
            this.btnStartImport = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.rtfMessages = new System.Windows.Forms.RichTextBox();
            this.txtInputFolder = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.txtTemplateFolder = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.txtTemplateFolder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOutputFolder, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInputFolderChoose, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOutputFolderChoose, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTemplateFolderChoose, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStartImport, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOutput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTemplate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtfMessages, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtInputFolder, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInputFolderChoose
            // 
            this.btnInputFolderChoose.Location = new System.Drawing.Point(563, 3);
            this.btnInputFolderChoose.Name = "btnInputFolderChoose";
            this.btnInputFolderChoose.Size = new System.Drawing.Size(31, 23);
            this.btnInputFolderChoose.TabIndex = 0;
            this.btnInputFolderChoose.Text = "...";
            this.btnInputFolderChoose.UseVisualStyleBackColor = true;
            this.btnInputFolderChoose.Click += new System.EventHandler(this.btnInputFolderChoose_Click);
            // 
            // btnOutputFolderChoose
            // 
            this.btnOutputFolderChoose.Location = new System.Drawing.Point(563, 33);
            this.btnOutputFolderChoose.Name = "btnOutputFolderChoose";
            this.btnOutputFolderChoose.Size = new System.Drawing.Size(31, 23);
            this.btnOutputFolderChoose.TabIndex = 1;
            this.btnOutputFolderChoose.Text = "...";
            this.btnOutputFolderChoose.UseVisualStyleBackColor = true;
            this.btnOutputFolderChoose.Click += new System.EventHandler(this.btnOutputFolderChoose_Click);
            // 
            // btnTemplateFolderChoose
            // 
            this.btnTemplateFolderChoose.Location = new System.Drawing.Point(563, 63);
            this.btnTemplateFolderChoose.Name = "btnTemplateFolderChoose";
            this.btnTemplateFolderChoose.Size = new System.Drawing.Size(31, 23);
            this.btnTemplateFolderChoose.TabIndex = 2;
            this.btnTemplateFolderChoose.Text = "...";
            this.btnTemplateFolderChoose.UseVisualStyleBackColor = true;
            this.btnTemplateFolderChoose.Click += new System.EventHandler(this.btnTemplateFolderChoose_Click);
            // 
            // btnStartImport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnStartImport, 2);
            this.btnStartImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartImport.Location = new System.Drawing.Point(513, 374);
            this.btnStartImport.Name = "btnStartImport";
            this.btnStartImport.Size = new System.Drawing.Size(81, 24);
            this.btnStartImport.TabIndex = 3;
            this.btnStartImport.Text = "Start";
            this.btnStartImport.UseVisualStyleBackColor = true;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInput.Location = new System.Drawing.Point(3, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(68, 30);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Input";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.Location = new System.Drawing.Point(3, 30);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(68, 30);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemplate.Location = new System.Drawing.Point(3, 60);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(68, 30);
            this.lblTemplate.TabIndex = 6;
            this.lblTemplate.Text = "Template";
            this.lblTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtfMessages
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtfMessages, 4);
            this.rtfMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfMessages.Location = new System.Drawing.Point(10, 95);
            this.rtfMessages.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.rtfMessages.Name = "rtfMessages";
            this.rtfMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtfMessages.Size = new System.Drawing.Size(577, 271);
            this.rtfMessages.TabIndex = 7;
            this.rtfMessages.Text = "";
            // 
            // txtInputFolder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtInputFolder, 2);
            this.txtInputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputFolder.Location = new System.Drawing.Point(77, 3);
            this.txtInputFolder.Name = "txtInputFolder";
            this.txtInputFolder.Size = new System.Drawing.Size(480, 22);
            this.txtInputFolder.TabIndex = 8;
            // 
            // txtOutputFolder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtOutputFolder, 2);
            this.txtOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutputFolder.Location = new System.Drawing.Point(77, 33);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(480, 22);
            this.txtOutputFolder.TabIndex = 9;
            // 
            // txtTemplateFolder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTemplateFolder, 2);
            this.txtTemplateFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplateFolder.Location = new System.Drawing.Point(77, 63);
            this.txtTemplateFolder.Name = "txtTemplateFolder";
            this.txtTemplateFolder.Size = new System.Drawing.Size(480, 22);
            this.txtTemplateFolder.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Folder Import";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnInputFolderChoose;
        private System.Windows.Forms.Button btnOutputFolderChoose;
        private System.Windows.Forms.Button btnTemplateFolderChoose;
        private System.Windows.Forms.Button btnStartImport;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.RichTextBox rtfMessages;
        private System.Windows.Forms.TextBox txtTemplateFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.TextBox txtInputFolder;
    }
}

