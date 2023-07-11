using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Form1 : Form
    {
        ftp ftpclient = new ftp();
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ftpclient.host = textBoxIP.Text.Trim();
                ftpclient.user = textBoxUsername.Text.Trim();
                ftpclient.pass = textBoxPassword.Text.Trim();
                ftpclient.ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ftpclient.host + "/test");
                ftpclient.ftpRequest.Credentials = new NetworkCredential(ftpclient.user, ftpclient.pass);
                ftpclient.ftpRequest.UseBinary = true;
                ftpclient.ftpRequest.UsePassive = true;
                ftpclient.ftpRequest.KeepAlive = true;
                ftpclient.ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpclient.ftpResponse = (FtpWebResponse)ftpclient.ftpRequest.GetResponse();
                ftpclient.ftpStream = ftpclient.ftpResponse.GetResponseStream();
                StreamReader ftpReader = new StreamReader(ftpclient.ftpStream);
                listView1.Clear();
                listView1.Columns.Add("File", 400);
                try
                {
                    while (ftpReader.Peek() != -1)
                    {
                        var item = new ListViewItem(new[] { ftpReader.ReadLine() });
                        listView1.Items.Add(item);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                ftpReader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }



        private void buttonUpload_Click(object sender, EventArgs e)
        {
            Upload Upload = new Upload(ftpclient);
            Upload.ShowDialog();
            buttonConnect_Click(sender, e);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = listView1.SelectedItems;
            ListViewItem item = selectedItems[0];
            string file = item.Text;
            Download Download = new Download(ftpclient, file);
            Download.Show();
        }
    }
}