namespace Lab06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelIP = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRemoteSite = new Label();
            textBoxIP = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonConnect = new Button();
            buttonUpload = new Button();
            buttonDownload = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Location = new Point(51, 26);
            labelIP.Name = "labelIP";
            labelIP.Size = new Size(74, 15);
            labelIP.TabIndex = 0;
            labelIP.Text = "IP FTP Server";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(51, 84);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(62, 15);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "UserName";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(51, 151);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelRemoteSite
            // 
            labelRemoteSite.AutoSize = true;
            labelRemoteSite.Location = new Point(51, 282);
            labelRemoteSite.Name = "labelRemoteSite";
            labelRemoteSite.Size = new Size(70, 15);
            labelRemoteSite.TabIndex = 3;
            labelRemoteSite.Text = "Remote Site";
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(143, 23);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(280, 23);
            textBoxIP.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(143, 81);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(280, 23);
            textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(143, 143);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(280, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(51, 203);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(111, 49);
            buttonConnect.TabIndex = 7;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Location = new Point(682, 300);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(97, 43);
            buttonUpload.TabIndex = 8;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(682, 395);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(97, 43);
            buttonDownload.TabIndex = 9;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 300);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(649, 138);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(buttonDownload);
            Controls.Add(buttonUpload);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxIP);
            Controls.Add(labelRemoteSite);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelIP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIP;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelRemoteSite;
        private TextBox textBoxIP;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonConnect;
        private Button buttonUpload;
        private Button buttonDownload;
        private ListView listView1;
    }
}