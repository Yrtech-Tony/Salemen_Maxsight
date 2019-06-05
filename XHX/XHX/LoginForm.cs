using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XHX.DTO;
using System.Configuration;
using XHX.Common;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace XHX
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        localhost.Service webService = new localhost.Service();
        LocalService localService = new LocalService();

        public LoginForm()
        {
            try
            {
                InitializeComponent();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                //Ping ping = new Ping();
                //PingReply pingReply = ping.Send(config.AppSettings.Settings["ServerIPAddress"].Value);
                //this.chkNet.Checked = (pingReply.Status == IPStatus.Success);
                chkNet.Checked = true;
                LookAndFeel.SetSkinStyle(config.AppSettings.Settings["SkinName"].Value);

                webService.SearchUserByUserIDCompleted += new XHX.localhost.SearchUserByUserIDCompletedEventHandler(webService_SearchUserByUserIDCompleted);

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text.Trim();
            string pwd = txtPWD.Text.Trim();

            if (chkNet.Checked)
            {
                webService.SearchUserByUserIDAsync(userID);
                this.Enabled = false;
            }
            else
            {
                DataSet ds = localService.SearchUserByUserID(userID);

                UserInfoDto userInfoDto = new UserInfoDto();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    userInfoDto.UserID = Convert.ToString(ds.Tables[0].Rows[0]["UserID"]);
                    userInfoDto.PSW = Convert.ToString(ds.Tables[0].Rows[0]["PSW"]);
                    userInfoDto.RoleType = Convert.ToString(ds.Tables[0].Rows[0]["RoleType"]);
                }

                if (!userID.Equals(userInfoDto.UserID))
                {
                    CommonHandler.ShowMessage(MessageType.Information, "”√ªß√˚¥ÌŒÛ°£"); return;
                }
                if (!pwd.Equals(userInfoDto.PSW))
                {
                    CommonHandler.ShowMessage(MessageType.Information, "√‹¬Î¥ÌŒÛ°£"); return;
                }
                userInfoDto.IsNetWork = false;

                MainForm mainForm = new MainForm();
                mainForm.UserInfoDto = userInfoDto;
                mainForm.Show();

                this.Hide();
            }
        }

        void webService_SearchUserByUserIDCompleted(object sender, XHX.localhost.SearchUserByUserIDCompletedEventArgs e)
        {
            this.Enabled = true;

            DataSet ds = e.Result;

            UserInfoDto userInfoDto = new UserInfoDto();
            if (ds.Tables[0].Rows.Count > 0)
            {
                userInfoDto.UserID = Convert.ToString(ds.Tables[0].Rows[0]["UserID"]);
                userInfoDto.PSW = Convert.ToString(ds.Tables[0].Rows[0]["PSW"]);
                userInfoDto.RoleType = Convert.ToString(ds.Tables[0].Rows[0]["RoleType"]);
            }

            string userID = txtUserID.Text.Trim();
            string pwd = txtPWD.Text.Trim();

            if (!userID.Equals(userInfoDto.UserID))
            {
                CommonHandler.ShowMessage(MessageType.Information, "”√ªß√˚¥ÌŒÛ°£"); return;
            }
            if (!pwd.Equals(userInfoDto.PSW))
            {
                CommonHandler.ShowMessage(MessageType.Information, "√‹¬Î¥ÌŒÛ°£"); return;
            }
            userInfoDto.IsNetWork = true;

            MainForm mainForm = new MainForm();
            mainForm.UserInfoDto = userInfoDto;
            mainForm.Show();

            this.Hide();
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(btnLogin, null);
            }
        }

       
       
    }
}