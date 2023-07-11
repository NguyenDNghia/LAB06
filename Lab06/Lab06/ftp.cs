using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class ftp
    {
        public string host = null;
        public string user = null;
        public string pass = null;
        public FtpWebRequest ftpRequest = null;
        public FtpWebResponse ftpResponse = null;
        public Stream ftpStream = null;
        public int bufferSize = 2048;


    }
}
