namespace _04_FileConverterForm
{
    partial class Form1
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.cmbBoxDest = new System.Windows.Forms.ComboBox();
            this.cmbBoxSource = new System.Windows.Forms.ComboBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(93, 163);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 28);
            this.btnConvert.TabIndex = 19;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(69, 67);
            this.txtBoxPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPath.TabIndex = 18;
            // 
            // cmbBoxDest
            // 
            this.cmbBoxDest.FormattingEnabled = true;
            this.cmbBoxDest.Items.AddRange(new object[] {
            ".jpg",
            ".png",
            ".tif",
            ".mp4",
            ".mpeg",
            ".wav",
            ".rar",
            ".mkv",
            ".txt"});
            this.cmbBoxDest.Location = new System.Drawing.Point(205, 99);
            this.cmbBoxDest.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxDest.Name = "cmbBoxDest";
            this.cmbBoxDest.Size = new System.Drawing.Size(65, 24);
            this.cmbBoxDest.TabIndex = 17;
            // 
            // cmbBoxSource
            // 
            this.cmbBoxSource.FormattingEnabled = true;
            this.cmbBoxSource.Location = new System.Drawing.Point(9, 99);
            this.cmbBoxSource.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxSource.Name = "cmbBoxSource";
            this.cmbBoxSource.Size = new System.Drawing.Size(65, 24);
            this.cmbBoxSource.TabIndex = 16;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(93, 27);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(100, 28);
            this.btnSelectFile.TabIndex = 15;
            this.btnSelectFile.Text = "File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 257);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.cmbBoxDest);
            this.Controls.Add(this.cmbBoxSource);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.ComboBox cmbBoxDest;
        private System.Windows.Forms.ComboBox cmbBoxSource;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

