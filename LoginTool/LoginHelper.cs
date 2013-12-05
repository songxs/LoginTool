using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace LoginTool
{
    sealed class LoginHelper
    {
        public delegate void DisplayEventHandler(string s);
        public DisplayEventHandler ShowMessage;

        private static readonly LoginHelper _instance = new LoginHelper();
        public static LoginHelper GetInstance()
        {
            return _instance;
        }

        private static string _loginURL = "http://172.30.0.94/";
        private static string _logoutURL = "http://172.30.0.94/F.htm";

        //private string _pinghost;
        //private int _pingtry;

        private LoginHelper() { }

        public void Logout()
        {
            ShowMessage("Logging out...");
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(_logoutURL);
            req.Method = "GET";
            using (WebResponse res = req.GetResponse())
            {
				//No need to handle logout response ectually
            }
        }

        public bool Login(string username, string password)
        {
            ShowMessage("Logging in...");
            string postData =
                "DDDDD=" + username +
                "&upass=" + password +
                "&0MKKey=";
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] postByte = encoding.GetBytes(postData);
            
			//All arguments copied from WireShark's package
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(_loginURL);
            req.Method = "POST";
            req.Accept = "text/html, application/xhtml+xml, */*";
            req.Referer = "http://172.30.0.94/";
            req.Headers.Add("Accept-Language", "zh-CN");
            req.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
            req.ContentType = "application/x-www-form-urlencoded";
            req.Headers.Add("Accept-Encoding", "gzip, deflate");
            req.Host = "172.30.0.94";
            req.ContentLength = postByte.Length;
            req.KeepAlive = true;
            req.Headers.Add("Cache-Control", "no-cache");
            req.ServicePoint.Expect100Continue = false;
            using (Stream stream = req.GetRequestStream())
            {
                stream.Write(postByte, 0, postByte.Length);
            }

            using (HttpWebResponse res = req.GetResponse() as HttpWebResponse)
            {
                StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding("gb2312"));
                string page = sr.ReadToEnd();
                string title = getHtmlTitle(page);

                if (title == "登录成功窗")
                {
                    ShowMessage("Succeeded!");
                    return true;
                }
                else
                {
                    ShowMessage("Failed!");
                    return false;
                }
            }
        }

		private static string getHtmlTitle(string html)
        {
            string title = "";
			Regex reg = new Regex(@"(?m)<title[^>]*>(?<title>(?:\w|\W)*?)</title[^>]*>", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            Match mc = reg.Match(html);
            if (mc.Success)
                title = mc.Groups["title"].Value.Trim();

            return title;
        }

        //public void Test(string host)
        //{
        //    _pinghost = host;
        //    _pingtry = 5;
        //    ShowMessage("Ping:" + host);
        //    Ping();
        //}

        //private void Ping()
        //{
        //    Ping p = new Ping();
        //    p.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);
        //    AutoResetEvent waiter = new AutoResetEvent(false);
        //    p.SendAsync(_pinghost, waiter);
        //}

        //private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        //{
        //    if (e.Cancelled)
        //    {
        //        ShowMessage("Ping canceled:" + e.Error.ToString());
        //    }
        //    if (e.Error != null)
        //    {
        //        ShowMessage("Ping failed:" + e.Error.ToString());
        //    }
        //    PingReply r = e.Reply;
        //    DisplayReply(r);
        //    if (r.Status != IPStatus.Success)
        //    {
        //        if ((_pingtry--) > 0)
        //            Ping();
        //        else
        //        {
        //            ShowMessage("Ping failed！");
        //        }
        //    }
        //    else
        //    {
        //        ShowMessage("Ping succeeded！");
        //    }
        //}

        //private void DisplayReply(PingReply reply)
        //{
        //    if (reply == null)
        //        return;
        //    if (reply.Status == IPStatus.Success)
        //    {
        //        ShowMessage("来自: " + reply.Address.ToString() + " 的回复：" +
        //            " 字节=" + reply.Buffer.Length.ToString() +
        //            " 时间=" + reply.RoundtripTime.ToString() +
        //            " TTL=" + reply.Options.Ttl.ToString());
        //    }
        //    else
        //    {
        //        ShowMessage(reply.Status.ToString());
        //    }
        //}    
    }
}
