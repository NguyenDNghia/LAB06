namespace Lab06
{
    partial class Upload
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
            labelFile = new Label();
            textBox1 = new TextBox();
            buttonBrowse = new Button();
            buttonUpload = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Location = new Point(181, 162);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(28, 15);
            labelFile.TabIndex = 0;
            labelFile.Text = "File:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(584, 159);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(34, 23);
            buttonBrowse.TabIndex = 2;
            buttonBrowse.Text = "...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Location = new Point(370, 243);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(75, 23);
            buttonUpload.TabIndex = 3;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 185);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "(Chon file de upload)";
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonUpload);
            Controls.Add(buttonBrowse);
            Controls.Add(textBox1);
            Controls.Add(labelFile);
            Name = "Upload";
            Text = "Upload";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFile;
        private TextBox textBox1;
        private Button buttonBrowse;
        private Button buttonUpload;
        private Label label1;
    }
}