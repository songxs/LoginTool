using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LoginTool
{
    public partial class ConfigForm : Form
    {
        public delegate void DisplayEventHandler(string s);
        public DisplayEventHandler ShowMessage;

        public delegate void SetNetworkAdapterHandler(
				string ip,
				string netmask,
				string defaultGateway,
				string dns1,
				string dns2
            );
        public SetNetworkAdapterHandler SetNetwork;

        private string _mac;
        private int _room;
        private int _seat;
        private string _user;
 
        private string _ip, _mask, _gateway, _dns1, _dns2;

        public ConfigForm(string mac)
        {
            _mac = mac;
            _room = -1;
            _seat = -1;
            _user = "";
            InitializeComponent();
            macTbx.Text = mac;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _room = Int32.Parse(roomTbx.Text);
                _seat = Byte.Parse(seatTbx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请正确填写房间号、座位号！");
                return;
            }
            _user = userTbx.Text;


            if (getRemoteConfig())
            {
                SetNetwork(_ip, _mask, _gateway, _dns1, _dns2);
                MessageBox.Show("配置成功!");
                this.Close();
            }
            else
            {
                MessageBox.Show("未能根据房间座位号获得配置，请检查设置或联系网管！");
            }
        }

        private bool getRemoteConfig()
        {
            ShowMessage("Fetching config...");

			StringBuilder sb = new StringBuilder();
            sb.Append("http://11.0.0.100/loginTool/register.php?");
            sb.AppendFormat("mac={0}&room={1}&seat={2}&user={3}", _mac, _room, _seat, _user);
            string reqUrl = sb.ToString();
            string rsltRaw;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(reqUrl);
            req.Method = "GET";

            using (HttpWebResponse res = req.GetResponse() as HttpWebResponse)
            {
                using (Stream stream = res.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    rsltRaw = sr.ReadToEnd();
                }
            }

            if (rsltRaw == "Invalid Room or Seat")
            {
                return false;
            }
            else
            {
                string[] tmp = rsltRaw.Split(' ');
                _ip = tmp[0];
                _mask = tmp[1];
                _gateway = tmp[2];
                _dns1 = tmp[3];
                _dns2 = tmp[4];
                return true;
            }
        }

        private void seatDiagramLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			//TODO: Try not to expose the web server url to public for security.
            System.Diagnostics.Process.Start("http://11.0.0.100/loginTool/seats.html");
        }
    }
}
