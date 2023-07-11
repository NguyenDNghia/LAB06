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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab06
{
    public partial class Download : Form
    {
        ftp ftpclient;
        string filename;
        public Download(ftp ftp, string filename)
        {
            InitializeComponent();
            ftpclient = ftp;
            this.filename = filename;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                }
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                ftpclient.ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ftpclient.host + "/" + filename);
                ftpclient.ftpRequest.Credentials = new NetworkCredential(ftpclient.user, ftpclient.pass);
                ftpclient.ftpRequest.UseBinary = true;
                ftpclient.ftpRequest.UsePassive = true;
                ftpclient.ftpRequest.KeepAlive = true;
                ftpclient.ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                ftpclient.ftpResponse = (FtpWebResponse)ftpclient.ftpRequest.GetResponse();
                ftpclient.ftpStream = ftpclient.ftpResponse.GetResponseStream();
                FileStream localFileStream = new FileStream(textBox1.Text.Trim(), FileMode.Create);
                byte[] byteBuffer = new byte[ftpclient.bufferSize];
                int bytesRead = ftpclient.ftpStream.Read(byteBuffer, 0, ftpclient.bufferSize);
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        bytesRead = ftpclient.ftpStream.Read(byteBuffer, 0, ftpclient.bufferSize);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                localFileStream.Close();
                ftpclient.ftpStream.Close();
                ftpclient.ftpResponse.Close();
                ftpclient.ftpRequest = null;
                MessageBox.Show("Download file thanh cong");
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
