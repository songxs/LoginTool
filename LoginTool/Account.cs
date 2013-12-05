using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using LoginTool.Exceptions;

namespace LoginTool
{
    class Account
    {
        public delegate void DisplayEventHandler(string s);
        public static DisplayEventHandler ShowMessage;

        private string _username, _password;
        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public bool Bad { get; set; }

        private readonly static Account _instance = new Account();

        private Account() { }

        public static Account GetInstance(string gateway)
        {
            string account = getRemoteAccount(gateway);
            if (account == "Router Not Found!")
            {
                _instance.Bad = true;
                throw new AccountException("Failed!!! --Invalid Gateway");
            }
            else
            {
                string[] tmp = account.Split(' ');
                _instance._username = tmp[0];
                _instance._password = tmp[1];
                _instance.Bad = false;
            }
            return _instance;
        }

        private static string getRemoteAccount(string gateway)
        {
            ShowMessage("Fetching account...");
            StringBuilder sb = new StringBuilder();
            sb.Append("http://11.0.0.100/loginTool/account.php?");
            sb.AppendFormat("whoami={0}&gateway={1}", "admin", gateway);
            string reqUrl = sb.ToString();

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(reqUrl);
            req.Method = "GET";

            using (HttpWebResponse res = req.GetResponse() as HttpWebResponse)
            {
                using (Stream stream = res.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    return sr.ReadToEnd();
                }
            }
        }

    }
}
