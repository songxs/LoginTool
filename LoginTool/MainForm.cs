using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LoginTool.Exceptions;

namespace LoginTool
{
    public partial class MainForm : Form
    {
        NetworkAdapter _adapter;
        Account _account;
        LoginHelper _loginHelper;

        public MainForm()
        {            
            InitializeComponent();
            _adapter = NetworkAdapter.GetInstance();
            _adapter.ShowMessage += ShowMessage;

            _loginHelper = LoginHelper.GetInstance();
            _loginHelper.ShowMessage += ShowMessage;

            Account.ShowMessage += ShowMessage;

            InfoBrowser.Navigate("11.0.0.100/loginTool/announcement.php");
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
	            ShowMessage("Getting network configuration...");
                _adapter.GetNetworkAdapter();
                _account = Account.GetInstance(_adapter.DefaultIPGateway[0]);
            }
            catch (AccountException ae)
            {
                ShowMessage(ae.Message);
                MessageBox.Show("获取账号失败，建议使用<设置-网卡配置>重设网卡配置！");
                return;
            }
            catch (Exception)
            {
                throw;
            }

            _loginHelper.Logout();
            if (_loginHelper.Login(_account.Username, _account.Password))
            {
                InfoBrowser.Navigate("http://www.baidu.com");
            }
        }

        private void ShowMessage(string m)
        {
            ResultTbx.AppendText(m);
            ResultTbx.AppendText(Environment.NewLine);
            ResultTbx.ScrollToCaret();
        }

        private void AboutMItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void AutoConfigMItem_Click(object sender, EventArgs e)
        {
            try
            {
                _adapter.GetNetworkAdapter();
            }
            catch (Exception)
            {
                throw;
            }
            ConfigForm configForm = new ConfigForm(_adapter.MACAddress);
            configForm.SetNetwork += _adapter.SetNetworkAdapter;
            configForm.ShowMessage += ShowMessage;
            configForm.Show();
        }
    }
}
