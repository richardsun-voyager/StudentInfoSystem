using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 用户操作类
        /// </summary>
        private UserManage userManage;
        private bool IsExit=false;
        /// <summary>
        /// 密码匹配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonCONFIRM_Click(object sender, EventArgs e)
        {
            userManage = new UserManage();
            if (textBoxLOGIN.Text == "")
            {
                labelStatus.Text = "用户名不能为空!";
            }
            else
            {
                MatchUser matchUser= userManage.UserLogin(textBoxLOGIN.Text, textBoxPW.Text);
                if (matchUser == MatchUser.登陆成功)
                {
                    this.Close();
                }
                else
                    labelStatus.Text = matchUser.ToString();
            }
        }
        public UserManage userManager
        {
            get { return userManage; }
        }
        public bool isExit
        {
            get { return IsExit; }
        }
        private void simpleButtonCANCEL_Click(object sender, EventArgs e)
        {
            IsExit = true;
            this.Close();
        }
    }
}