namespace StudentManagement
{
    partial class CP_PersonLeave
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTEAM = new System.Windows.Forms.ComboBox();
            this.comboBoxGRADE = new System.Windows.Forms.ComboBox();
            this.radioGroupREASON = new DevExpress.XtraEditors.RadioGroup();
            this.richTextBoxMARK = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerTO = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFROM = new System.Windows.Forms.DateTimePicker();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.buttonTAKINGLEAVE = new System.Windows.Forms.Button();
            this.studentRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
         
            this.studentLeaveRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         
            this.gridControlLEAVES = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCtrl_StudentInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupREASON.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRecordsBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.studentLeaveRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLEAVES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl_StudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTEAM);
            this.groupBox1.Controls.Add(this.comboBoxGRADE);
            this.groupBox1.Controls.Add(this.radioGroupREASON);
            this.groupBox1.Controls.Add(this.richTextBoxMARK);
            this.groupBox1.Controls.Add(this.dateTimePickerTO);
            this.groupBox1.Controls.Add(this.dateTimePickerFROM);
            this.groupBox1.Controls.Add(this.textEditID);
            this.groupBox1.Controls.Add(this.textBoxNAME);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人请销假";
            // 
            // comboBoxTEAM
            // 
            this.comboBoxTEAM.FormattingEnabled = true;
            this.comboBoxTEAM.Items.AddRange(new object[] {
            "一区队",
            "二区队",
            "三区队",
            "四区队",
            "五区队",
            "六区队"});
            this.comboBoxTEAM.Location = new System.Drawing.Point(281, 59);
            this.comboBoxTEAM.Name = "comboBoxTEAM";
            this.comboBoxTEAM.Size = new System.Drawing.Size(118, 20);
            this.comboBoxTEAM.TabIndex = 10;
            // 
            // comboBoxGRADE
            // 
            this.comboBoxGRADE.FormattingEnabled = true;
            this.comboBoxGRADE.Items.AddRange(new object[] {
            "2007级",
            "2008级"});
            this.comboBoxGRADE.Location = new System.Drawing.Point(77, 59);
            this.comboBoxGRADE.Name = "comboBoxGRADE";
            this.comboBoxGRADE.Size = new System.Drawing.Size(117, 20);
            this.comboBoxGRADE.TabIndex = 10;
            // 
            // radioGroupREASON
            // 
            this.radioGroupREASON.Location = new System.Drawing.Point(632, 52);
            this.radioGroupREASON.Name = "radioGroupREASON";
            this.radioGroupREASON.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.radioGroupREASON.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupREASON.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "事假"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "出差"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "病假")});
            this.radioGroupREASON.Size = new System.Drawing.Size(157, 28);
            this.radioGroupREASON.TabIndex = 9;
            // 
            // richTextBoxMARK
            // 
            this.richTextBoxMARK.BackColor = System.Drawing.Color.White;
            this.richTextBoxMARK.Location = new System.Drawing.Point(797, 25);
            this.richTextBoxMARK.Name = "richTextBoxMARK";
            this.richTextBoxMARK.Size = new System.Drawing.Size(137, 65);
            this.richTextBoxMARK.TabIndex = 7;
            this.richTextBoxMARK.Text = "";
            // 
            // dateTimePickerTO
            // 
            this.dateTimePickerTO.Location = new System.Drawing.Point(632, 25);
            this.dateTimePickerTO.Name = "dateTimePickerTO";
            this.dateTimePickerTO.Size = new System.Drawing.Size(108, 21);
            this.dateTimePickerTO.TabIndex = 6;
            // 
            // dateTimePickerFROM
            // 
            this.dateTimePickerFROM.Location = new System.Drawing.Point(488, 25);
            this.dateTimePickerFROM.Name = "dateTimePickerFROM";
            this.dateTimePickerFROM.Size = new System.Drawing.Size(108, 21);
            this.dateTimePickerFROM.TabIndex = 6;
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(77, 23);
            this.textEditID.Name = "textEditID";
            this.textEditID.Properties.Mask.EditMask = "d8";
            this.textEditID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditID.Size = new System.Drawing.Size(117, 21);
            this.textEditID.TabIndex = 5;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.BackColor = System.Drawing.Color.White;
            this.textBoxNAME.Location = new System.Drawing.Point(281, 25);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(118, 21);
            this.textBoxNAME.TabIndex = 4;
            this.textBoxNAME.MouseEnter += new System.EventHandler(this.textBoxNAME_MouseEnter);
            this.textBoxNAME.TextChanged += new System.EventHandler(this.textBoxNAME_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "请假起止时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "区队";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "备注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "年级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "请假原因";
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(8, 272);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 8;
            this.buttonCANCEL.Text = "销假";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // buttonTAKINGLEAVE
            // 
            this.buttonTAKINGLEAVE.Location = new System.Drawing.Point(6, 99);
            this.buttonTAKINGLEAVE.Name = "buttonTAKINGLEAVE";
            this.buttonTAKINGLEAVE.Size = new System.Drawing.Size(75, 23);
            this.buttonTAKINGLEAVE.TabIndex = 8;
            this.buttonTAKINGLEAVE.Text = "请假";
            this.buttonTAKINGLEAVE.UseVisualStyleBackColor = true;
            this.buttonTAKINGLEAVE.Click += new System.EventHandler(this.buttonTAKINGLEAVE_Click);
            // 
            // studentRecordsBindingSource
            // 
            this.studentRecordsBindingSource.DataMember = "StudentRecords";
   
            
            // 
            // studentDataSetBindingSource
            // 

            this.studentDataSetBindingSource.Position = 0;
            // 

         
            // 
            // studentLeaveRecordsBindingSource
            // 
            this.studentLeaveRecordsBindingSource.DataMember = "StudentLeaveRecords";
   
            // 

            // 
            // gridControlLEAVES
            // 
            this.gridControlLEAVES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLEAVES.EmbeddedNavigator.Name = "";
            this.gridControlLEAVES.Location = new System.Drawing.Point(500, 107);
            this.gridControlLEAVES.MainView = this.gridView1;
            this.gridControlLEAVES.Name = "gridControlLEAVES";
            this.gridControlLEAVES.Size = new System.Drawing.Size(453, 380);
            this.gridControlLEAVES.TabIndex = 4;
            this.gridControlLEAVES.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControlLEAVES;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFilterPanel = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "学号";
            this.gridColumn9.FieldName = "ID";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 36;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "姓名";
            this.gridColumn2.FieldName = "NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 36;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "区队";
            this.gridColumn3.FieldName = "TEAM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 36;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "班";
            this.gridColumn4.FieldName = "CLASS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 24;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "请假日期";
            this.gridColumn5.FieldName = "LEAVEDATE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 60;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "归假日期";
            this.gridColumn6.FieldName = "DUEDATE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 60;
            // 
            // gridCtrl_StudentInfo
            // 
            this.gridCtrl_StudentInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridCtrl_StudentInfo.EmbeddedNavigator.Name = "";
            this.gridCtrl_StudentInfo.Location = new System.Drawing.Point(0, 107);
            this.gridCtrl_StudentInfo.MainView = this.gridView2;
            this.gridCtrl_StudentInfo.Name = "gridCtrl_StudentInfo";
            this.gridCtrl_StudentInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridCtrl_StudentInfo.Size = new System.Drawing.Size(411, 380);
            this.gridCtrl_StudentInfo.TabIndex = 31;
            this.gridCtrl_StudentInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn8,
            this.gridColumn12,
            this.gridColumn14,
            this.gridColumn15});
            this.gridView2.GridControl = this.gridCtrl_StudentInfo;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "年级";
            this.gridColumn7.FieldName = "GRADE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "学号";
            this.gridColumn1.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.BeepOnError = true;
            this.repositoryItemTextEdit1.Mask.EditMask = "d8";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "姓名";
            this.gridColumn8.FieldName = "NAME";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "籍贯";
            this.gridColumn12.FieldName = "ADDRESS";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "区队";
            this.gridColumn14.FieldName = "TEAM";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "是否党员";
            this.gridColumn15.FieldName = "IsPartyMember";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTAKINGLEAVE);
            this.panel1.Controls.Add(this.buttonCANCEL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(411, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 380);
            this.panel1.TabIndex = 32;
            // 
            // CP_PersonLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlLEAVES);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridCtrl_StudentInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "CP_PersonLeave";
            this.Size = new System.Drawing.Size(953, 487);
            this.Load += new System.EventHandler(this.CP_PersonLeave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupREASON.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRecordsBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.studentLeaveRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLEAVES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl_StudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxMARK;
        private System.Windows.Forms.DateTimePicker dateTimePickerTO;
        private System.Windows.Forms.DateTimePicker dateTimePickerFROM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.Button buttonTAKINGLEAVE;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;

        private System.Windows.Forms.BindingSource studentRecordsBindingSource;
 

        private System.Windows.Forms.BindingSource studentLeaveRecordsBindingSource;
  
        private DevExpress.XtraGrid.GridControl gridControlLEAVES;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.RadioGroup radioGroupREASON;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGRADE;
        private System.Windows.Forms.ComboBox comboBoxTEAM;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridCtrl_StudentInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.Panel panel1;
    }
}
