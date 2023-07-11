namespace Lab06
{
    partial class Download
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
            buttonDownload = new Button();
            buttonBrowse = new Button();
            textBox1 = new TextBox();
            labelFile = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(371, 256);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(75, 23);
            buttonDownload.TabIndex = 7;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(585, 172);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(34, 23);
            buttonBrowse.TabIndex = 6;
            buttonBrowse.Text = "...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 5;
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Location = new Point(182, 175);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(28, 15);
            labelFile.TabIndex = 4;
            labelFile.Text = "File:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 198);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 8;
            label1.Text = "(Chon file de luu du lieu tu file tai ve)";
            // 
            // Download
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonDownload);
            Controls.Add(buttonBrowse);
            Controls.Add(textBox1);
            Controls.Add(labelFile);
            Name = "Download";
            Text = "Download";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDownload;
        private Button buttonBrowse;
        private TextBox textBox1;
        private Label labelFile;
        private Label label1;
    }
}