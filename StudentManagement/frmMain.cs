using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace StudentManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region"变量定义区"
        private CP_WELCOME welcome;
        private CP_BrigadeInfo brigadeInfo;
        private CP_BrigadeManage brigadeManage;
        private CP_PersonInfo personInfo;
        private CP_PersonLeave personLeave;
        private CP_TakingGroupLeaves groupLeaves;
        private CP_StudentPunishmentRecords punishmentRecords;
        private CP_LEAVESQUERY leavesQuery;
        private PersonInfo personinfo;
        private UserControl CurrentPanel;
        #endregion

        #region 功能函数
        /// <summary>
        /// 主界面添加界面显示
        /// </summary>
        /// <param name="userControl"></param>
        private void AddPanel(UserControl userControl)
        {
            MainPanel.Controls.Add(userControl);
            CurrentPanel = userControl;
            userControl.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// 删除当前显示元素
        /// </summary>
        private void RemovePanel()
        {
            MainPanel.Controls.Remove(CurrentPanel);
        }
        /// <summary>
        /// 显示当前元素
        /// </summary>
        /// <param name="userControl"></param>
        private void ShowUserControl(UserControl userControl)
        {
            if (CurrentPanel != null)
                RemovePanel();
            CurrentPanel = userControl;
            AddPanel(CurrentPanel);
        }
        /// <summary>
        /// 获取超假人员信息
        /// </summary>
        private void GetOverdatePersonInfo()
        {
            //获取超假人员信息
            DataTable dt = personinfo.GetOverdatePersonInfoTable();
            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                notifyIcon1.BalloonTipTitle = "超假人员信息";
                notifyIcon1.BalloonTipText = dr["NAME"].ToString() + "等人尚未销假!请急速销假!";
                notifyIcon1.ShowBalloonTip(3);
            }
        }
        #endregion

        #region 事件函数
        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            CurrentPanel = new UserControl();
            welcome = new CP_WELCOME();
            CurrentPanel = welcome;
            AddPanel(CurrentPanel);
            toolStripStatusLabel2.Text = DateTime.Today.Date.ToString();
            personinfo = new PersonInfo();
            GetOverdatePersonInfo();
            timer1.Enabled = true;
            //用户登录
            frmLogin frmlogin = new frmLogin();
            frmlogin.ShowDialog();
            if (frmlogin.isExit)
            {
                this.Close();
                this.Dispose();
            }
            else if (frmlogin.userManager.UserRole == "User")
            {
                navBarGroup2.Visible = false;
                navBarGroup3.Visible = false;
            }
        }


        /// <summary>
        /// 出勤率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItemCQL_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CurrentPanel != null)
                RemovePanel();
            brigadeManage = new CP_BrigadeManage();
            CurrentPanel = brigadeManage;
            AddPanel(CurrentPanel);
            
        }
        /// <summary>
        /// 批量请假
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GROUPLEAVE_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupLeaves = new CP_TakingGroupLeaves();
            ShowUserControl(groupLeaves);

        }
        /// <summary>
        /// 请假查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LEAVESQUERY_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CurrentPanel != null)
                RemovePanel();
            leavesQuery = new CP_LEAVESQUERY();
            CurrentPanel = leavesQuery;
            AddPanel(CurrentPanel);
        }
        /// <summary>
        /// 处罚查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PUNISHMENTQUERY_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            punishmentRecords = new CP_StudentPunishmentRecords(false);
            ShowUserControl(punishmentRecords);
        }
        /// <summary>
        /// 个人信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PERSININFOQUERY_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CurrentPanel != null)
                RemovePanel();
            personInfo = new CP_PersonInfo(false);
            CurrentPanel = personInfo;
            AddPanel(CurrentPanel);

        }
        /// <summary>
        /// 个人信息编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PERSONINFOEDIT_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CurrentPanel != null)
                RemovePanel();
            personInfo = new CP_PersonInfo(true);
            CurrentPanel = personInfo;
            AddPanel(CurrentPanel);
        }
        
        /// <summary>
        /// 个人请假
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PERSONLEAVE_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CurrentPanel != null)
                RemovePanel();
            personLeave = new CP_PersonLeave();
            CurrentPanel = personLeave;
            AddPanel(CurrentPanel);
        }
        #endregion

        /// <summary>
        /// 退出清理所有进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            notifyIcon1.Dispose();
            Application.Exit();
        }
        /// <summary>
        /// 托盘显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetOverdatePersonInfo();
        }
        /// <summary>
        /// 系统配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SYSTEMCONFIG_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSysConfig sysConfig = new frmSysConfig();
            if (sysConfig.ShowDialog() == DialogResult.OK)
            {
                sysConfig.SetTimer(timer1);
            }
        }
        /// <summary>
        /// 最小化至托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏
                notifyIcon1.Visible = true;  //托盘图标可见
            }
        }
        /// <summary>
        /// 帮助对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemABOUT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAbout frmabout = new frmAbout();
            frmabout.ShowDialog();
        }
        /// <summary>
        /// 量化操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItemQUANTATIZE_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            punishmentRecords = new CP_StudentPunishmentRecords(true);
            ShowUserControl(punishmentRecords);
        }


    }
}