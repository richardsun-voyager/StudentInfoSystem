namespace StudentManagement
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemLEAVESQUERY = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemINSPECT = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemPERSONINFOQUERY = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemPUNISHMENTQUERY = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPERSONLEAVE = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemGROUPLEAVE = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemQUANTATIZE = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPERSONINFOEDIT = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSYSTEMCONFIG = new DevExpress.XtraNavBar.NavBarItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemHELP = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemABOUT = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Liquid Sky";
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemPERSONINFOQUERY,
            this.navBarItemPERSONINFOEDIT,
            this.navBarItem4,
            this.navBarItemPERSONLEAVE,
            this.navBarItemGROUPLEAVE,
            this.navBarItemINSPECT,
            this.navBarItemLEAVESQUERY,
            this.navBarItemQUANTATIZE,
            this.navBarItemPUNISHMENTQUERY,
            this.navBarItemSYSTEMCONFIG});
            this.navBarControl1.Location = new System.Drawing.Point(0, 53);
            this.navBarControl1.LookAndFeel.SkinName = "Liquid Sky";
            this.navBarControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarControl1.LookAndFeel.UseWindowsXPTheme = false;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(134, 624);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "勤管状态查看";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemLEAVESQUERY),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemINSPECT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPERSONINFOQUERY),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPUNISHMENTQUERY)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemLEAVESQUERY
            // 
            this.navBarItemLEAVESQUERY.Appearance.Options.UseTextOptions = true;
            this.navBarItemLEAVESQUERY.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItemLEAVESQUERY.Caption = "请销假统计";
            this.navBarItemLEAVESQUERY.Name = "navBarItemLEAVESQUERY";
            this.navBarItemLEAVESQUERY.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.LEAVESQUERY_Clicked);
            // 
            // navBarItemINSPECT
            // 
            this.navBarItemINSPECT.Appearance.Options.UseTextOptions = true;
            this.navBarItemINSPECT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItemINSPECT.Caption = "出勤状况查看";
            this.navBarItemINSPECT.Name = "navBarItemINSPECT";
            this.navBarItemINSPECT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemCQL_Clicked);
            // 
            // navBarItemPERSONINFOQUERY
            // 
            this.navBarItemPERSONINFOQUERY.Appearance.Options.UseTextOptions = true;
            this.navBarItemPERSONINFOQUERY.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItemPERSONINFOQUERY.Caption = "个人信息查询";
            this.navBarItemPERSONINFOQUERY.Name = "navBarItemPERSONINFOQUERY";
            this.navBarItemPERSONINFOQUERY.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.PERSININFOQUERY_Clicked);
            // 
            // navBarItemPUNISHMENTQUERY
            // 
            this.navBarItemPUNISHMENTQUERY.Caption = "量化查看";
            this.navBarItemPUNISHMENTQUERY.Name = "navBarItemPUNISHMENTQUERY";
            this.navBarItemPUNISHMENTQUERY.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.PUNISHMENTQUERY_Clicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "勤管操作";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPERSONLEAVE),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemGROUPLEAVE),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemQUANTATIZE)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemPERSONLEAVE
            // 
            this.navBarItemPERSONLEAVE.Appearance.Options.UseTextOptions = true;
            this.navBarItemPERSONLEAVE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItemPERSONLEAVE.Caption = "个人请假";
            this.navBarItemPERSONLEAVE.Name = "navBarItemPERSONLEAVE";
            this.navBarItemPERSONLEAVE.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.PERSONLEAVE_Clicked);
            // 
            // navBarItemGROUPLEAVE
            // 
            this.navBarItemGROUPLEAVE.Appearance.Options.UseTextOptions = true;
            this.navBarItemGROUPLEAVE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItemGROUPLEAVE.Caption = "批量请假";
            this.navBarItemGROUPLEAVE.Name = "navBarItemGROUPLEAVE";
            this.navBarItemGROUPLEAVE.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.GROUPLEAVE_Clicked);
            // 
            // navBarItemQUANTATIZE
            // 
            this.navBarItemQUANTATIZE.Appearance.Options.UseTextOptions = true;
            this.navBarItemQUANTATIZE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItemQUANTATIZE.Caption = "量化";
            this.navBarItemQUANTATIZE.Name = "navBarItemQUANTATIZE";
            this.navBarItemQUANTATIZE.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemQUANTATIZE_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "基本信息设置";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPERSONINFOEDIT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSYSTEMCONFIG)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItemPERSONINFOEDIT
            // 
            this.navBarItemPERSONINFOEDIT.Appearance.Options.UseTextOptions = true;
            this.navBarItemPERSONINFOEDIT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItemPERSONINFOEDIT.Caption = "个人信息编辑";
            this.navBarItemPERSONINFOEDIT.Name = "navBarItemPERSONINFOEDIT";
            this.navBarItemPERSONINFOEDIT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.PERSONINFOEDIT_Clicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Appearance.Options.UseTextOptions = true;
            this.navBarItem4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarItem4.Caption = "学员队组织管理";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItemSYSTEMCONFIG
            // 
            this.navBarItemSYSTEMCONFIG.Caption = "系统设置";
            this.navBarItemSYSTEMCONFIG.Name = "navBarItemSYSTEMCONFIG";
            this.navBarItemSYSTEMCONFIG.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.SYSTEMCONFIG_Clicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "日期";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(134, 53);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1032, 624);
            this.MainPanel.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "学员队勤管系统";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barSubItemHELP,
            this.barButtonItemABOUT});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemHELP)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "系统(&S)";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "系统设置";
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "退出";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "查看(&L)";
            this.barSubItem2.Id = 2;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "操作(&E)";
            this.barSubItem3.Id = 3;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItemHELP
            // 
            this.barSubItemHELP.Caption = "帮助(&H)";
            this.barSubItemHELP.Id = 9;
            this.barSubItemHELP.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemABOUT)});
            this.barSubItemHELP.Name = "barSubItemHELP";
            // 
            // barButtonItemABOUT
            // 
            this.barButtonItemABOUT.Caption = "关于(&A)";
            this.barButtonItemABOUT.Id = 10;
            this.barButtonItemABOUT.Name = "barButtonItemABOUT";
            this.barButtonItemABOUT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemABOUT_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 2";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar2.Text = "Custom 2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "出勤记录";
            this.barButtonItem3.Description = "出勤记录";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageIndex = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "请销假";
            this.barButtonItem4.Description = "请销假";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageIndex = 1;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "量化";
            this.barButtonItem5.Description = "量化";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.ImageIndex = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.barDockControlTop.Appearance.Options.UseBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.ico");
            this.imageList1.Images.SetKeyName(1, "2.ico");
            this.imageList1.Images.SetKeyName(2, "3.bmp");
            this.imageList1.Images.SetKeyName(3, "3.ico");
            this.imageList1.Images.SetKeyName(4, "4.bmp");
            this.imageList1.Images.SetKeyName(5, "5.bmp");
            this.imageList1.Images.SetKeyName(6, "6.bmp");
            this.imageList1.Images.SetKeyName(7, "7.bmp");
            this.imageList1.Images.SetKeyName(8, "8.bmp");
            this.imageList1.Images.SetKeyName(9, "9.bmp");
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "查询";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 699);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学员队勤管系统";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPERSONINFOQUERY;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPERSONLEAVE;
        private DevExpress.XtraNavBar.NavBarItem navBarItemGROUPLEAVE;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPERSONINFOEDIT;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItemLEAVESQUERY;
        private DevExpress.XtraNavBar.NavBarItem navBarItemINSPECT;
        private DevExpress.XtraNavBar.NavBarItem navBarItemQUANTATIZE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel MainPanel;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPUNISHMENTQUERY;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSYSTEMCONFIG;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarSubItem barSubItemHELP;
        private DevExpress.XtraBars.BarButtonItem barButtonItemABOUT;

    }
}

