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
        /// �û�������
        /// </summary>
        private UserManage userManage;
        private bool IsExit=false;
        /// <summary>
        /// ����ƥ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonCONFIRM_Click(object sender, EventArgs e)
        {
            userManage = new UserManage();
            if (textBoxLOGIN.Text == "")
            {
                labelStatus.Text = "�û�������Ϊ��!";
            }
            else
            {
                MatchUser matchUser= userManage.UserLogin(textBoxLOGIN.Text, textBoxPW.Text);
                if (matchUser == MatchUser.��½�ɹ�)
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