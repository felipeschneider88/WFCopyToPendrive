namespace WFCopyInfo
{
    partial class frmCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopy));
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnProcess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpboxOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.grpboxOutput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(368, 418);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(101, 45);
            this.btnCopiar.TabIndex = 0;
            this.btnCopiar.Text = "Copy";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(74, 9);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(250, 20);
            this.txtSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(74, 42);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(100, 20);
            this.txtFolder.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(330, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 418);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(101, 45);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Test";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Visible = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // grpboxOutput
            // 
            this.grpboxOutput.Controls.Add(this.txtOutput);
            this.grpboxOutput.Location = new System.Drawing.Point(23, 163);
            this.grpboxOutput.Name = "grpboxOutput";
            this.grpboxOutput.Size = new System.Drawing.Size(448, 249);
            this.grpboxOutput.TabIndex = 8;
            this.grpboxOutput.TabStop = false;
            this.grpboxOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.MaxLength = 0;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(442, 230);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxScript);
            this.groupBox1.Location = new System.Drawing.Point(23, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command";
            this.groupBox1.Visible = false;
            // 
            // textBoxScript
            // 
            this.textBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxScript.Location = new System.Drawing.Point(3, 16);
            this.textBoxScript.MaxLength = 0;
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxScript.Size = new System.Drawing.Size(445, 38);
            this.textBoxScript.TabIndex = 1;
            this.textBoxScript.Text = "Get-Process";
            this.textBoxScript.WordWrap = false;
            // 
            // frmCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpboxOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnCopiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCopy";
            this.Text = "WFCopyInfo";
            this.Load += new System.EventHandler(this.frmCopy_Load);
            this.grpboxOutput.ResumeLayout(false);
            this.grpboxOutput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpboxOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxScript;
    }
}

