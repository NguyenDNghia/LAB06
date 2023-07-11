using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Upload : Form
    {
        ftp ftpclient;
        string filename;
        public Upload(ftp ftp)
        {
            InitializeComponent();
            ftpclient = ftp;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    filename = ofd.SafeFileName;
                }
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                ftpclient.ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ftpclient.host + "/test/" + filename);
                ftpclient.ftpRequest.Credentials = new NetworkCredential(ftpclient.user, ftpclient.pass);
                ftpclient.ftpRequest.UseBinary = true;
                ftpclient.ftpRequest.UsePassive = true;
                ftpclient.ftpRequest.KeepAlive = true;
                ftpclient.ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpclient.ftpStream = ftpclient.ftpRequest.GetRequestStream();
                FileStream localFileStream = new FileStream(textBox1.Text.Trim(), FileMode.Open);
                byte[] byteBuffer = new byte[ftpclient.bufferSize];
                int bytesSent = localFileStream.Read(byteBuffer, 0, ftpclient.bufferSize);
                try
                {
                    while (bytesSent != 0)
                    {
                        ftpclient.ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = localFileStream.Read(byteBuffer, 0, ftpclient.bufferSize);
                    }
                    MessageBox.Show("Upload file thanh cong");
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                localFileStream.Close();
                ftpclient.ftpStream.Close();
                ftpclient.ftpRequest = null;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
