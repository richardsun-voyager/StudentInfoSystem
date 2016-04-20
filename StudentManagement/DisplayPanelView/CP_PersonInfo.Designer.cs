namespace StudentManagement
{
    /// <summary>
    /// 学生信息界面
    /// </summary>
    partial class CP_PersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CP_PersonInfo));
            this.gridCtrl_StudentInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBoxEditCLASS = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.textEditNAME = new DevExpress.XtraEditors.TextEdit();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.checkBoxCadre = new System.Windows.Forms.CheckBox();
            this.checkBoxPartyMember = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEditTEAM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditGRADE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.buttonModify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBIRTHDAY = new System.Windows.Forms.DateTimePicker();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonSELECTPIC = new System.Windows.Forms.Button();
            this.textEditPICPATH = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxMARK = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBoxSHOWALL = new System.Windows.Forms.CheckBox();
            this.checkBoxCLEAR = new System.Windows.Forms.CheckBox();
            this.radioGroupGENDER = new DevExpress.XtraEditors.RadioGroup();
            this.textEditPHONE = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl_StudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCLASS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTEAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGRADE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditADDRESS.Properties)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPICPATH.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupGENDER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPHONE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrl_StudentInfo
            // 
            this.gridCtrl_StudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrl_StudentInfo.EmbeddedNavigator.Name = "";
            this.gridCtrl_StudentInfo.Location = new System.Drawing.Point(0, 199);
            this.gridCtrl_StudentInfo.MainView = this.gridView1;
            this.gridCtrl_StudentInfo.Name = "gridCtrl_StudentInfo";
            this.gridCtrl_StudentInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridCtrl_StudentInfo.Size = new System.Drawing.Size(1064, 503);
            this.gridCtrl_StudentInfo.TabIndex = 30;
            this.gridCtrl_StudentInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn8,
            this.gridColumn10,
            this.gridColumn9,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridCtrl_StudentInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "姓名";
            this.gridColumn2.FieldName = "NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "性别";
            this.gridColumn8.FieldName = "GENDER";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "出生年月";
            this.gridColumn10.FieldName = "BIRTHDAY";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "籍贯";
            this.gridColumn9.FieldName = "ADDRESS";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "班";
            this.gridColumn3.FieldName = "CLASS";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "区队";
            this.gridColumn4.FieldName = "TEAM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "是否党员";
            this.gridColumn5.FieldName = "IsPartyMember";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 8;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "是否骨干";
            this.gridColumn6.FieldName = "IsCadre";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "手机";
            this.gridColumn11.FieldName = "CONTACT";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // comboBoxEditCLASS
            // 
            this.comboBoxEditCLASS.Location = new System.Drawing.Point(213, 50);
            this.comboBoxEditCLASS.Name = "comboBoxEditCLASS";
            this.comboBoxEditCLASS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditCLASS.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEditCLASS.TabIndex = 29;
            this.comboBoxEditCLASS.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.comboBoxEditCLASS.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditCLASS_SelectedIndexChanged);
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(213, 20);
            this.textEditID.Name = "textEditID";
            this.textEditID.Properties.Mask.BeepOnError = true;
            this.textEditID.Size = new System.Drawing.Size(100, 21);
            this.textEditID.TabIndex = 31;
            this.textEditID.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.textEditID.EditValueChanged += new System.EventHandler(this.textEditID_EditValueChanged);
            // 
            // textEditNAME
            // 
            this.textEditNAME.Location = new System.Drawing.Point(369, 19);
            this.textEditNAME.Name = "textEditNAME";
            this.textEditNAME.Size = new System.Drawing.Size(100, 21);
            this.textEditNAME.TabIndex = 32;
            this.textEditNAME.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.textEditNAME.EditValueChanged += new System.EventHandler(this.textEditNAME_EditValueChanged);
            // 
            // buttonDEL
            // 
            this.buttonDEL.Enabled = false;
            this.buttonDEL.Location = new System.Drawing.Point(411, 17);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(75, 23);
            this.buttonDEL.TabIndex = 26;
            this.buttonDEL.Text = "删除";
            this.buttonDEL.UseVisualStyleBackColor = true;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(94, 17);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 25;
            this.buttonADD.Text = "添加学员";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // checkBoxCadre
            // 
            this.checkBoxCadre.AutoSize = true;
            this.checkBoxCadre.Location = new System.Drawing.Point(279, 118);
            this.checkBoxCadre.Name = "checkBoxCadre";
            this.checkBoxCadre.Size = new System.Drawing.Size(48, 16);
            this.checkBoxCadre.TabIndex = 21;
            this.checkBoxCadre.Text = "骨干";
            this.checkBoxCadre.UseVisualStyleBackColor = true;
            this.checkBoxCadre.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.checkBoxCadre.CheckedChanged += new System.EventHandler(this.checkBoxCadre_CheckedChanged);
            // 
            // checkBoxPartyMember
            // 
            this.checkBoxPartyMember.AutoSize = true;
            this.checkBoxPartyMember.Checked = true;
            this.checkBoxPartyMember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPartyMember.Location = new System.Drawing.Point(209, 118);
            this.checkBoxPartyMember.Name = "checkBoxPartyMember";
            this.checkBoxPartyMember.Size = new System.Drawing.Size(48, 16);
            this.checkBoxPartyMember.TabIndex = 20;
            this.checkBoxPartyMember.Text = "党员";
            this.checkBoxPartyMember.UseVisualStyleBackColor = true;
            this.checkBoxPartyMember.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.checkBoxPartyMember.CheckedChanged += new System.EventHandler(this.checkBoxPartyMember_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "班";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "区队";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "学号";
            // 
            // comboBoxEditTEAM
            // 
            this.comboBoxEditTEAM.EditValue = "一区队";
            this.comboBoxEditTEAM.Location = new System.Drawing.Point(51, 49);
            this.comboBoxEditTEAM.Name = "comboBoxEditTEAM";
            this.comboBoxEditTEAM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditTEAM.Properties.Items.AddRange(new object[] {
            "全部",
            "一区队",
            "二区队",
            "三区队",
            "四区队",
            "五区队",
            "六区队"});
            this.comboBoxEditTEAM.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEditTEAM.TabIndex = 28;
            this.comboBoxEditTEAM.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.comboBoxEditTEAM.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditTEAM_SelectedIndexChanged);
            // 
            // comboBoxEditGRADE
            // 
            this.comboBoxEditGRADE.EditValue = "2007";
            this.comboBoxEditGRADE.Location = new System.Drawing.Point(51, 20);
            this.comboBoxEditGRADE.Name = "comboBoxEditGRADE";
            this.comboBoxEditGRADE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditGRADE.Properties.Items.AddRange(new object[] {
            "",
            "2007",
            "2008"});
            this.comboBoxEditGRADE.Properties.Mask.EditMask = "d8";
            this.comboBoxEditGRADE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.comboBoxEditGRADE.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEditGRADE.TabIndex = 29;
            this.comboBoxEditGRADE.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.comboBoxEditGRADE.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditGRADE_SelectedIndexChanged);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(252, 17);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 25;
            this.buttonModify.Text = "修改";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "籍贯";
            // 
            // textEditADDRESS
            // 
            this.textEditADDRESS.Location = new System.Drawing.Point(368, 50);
            this.textEditADDRESS.Name = "textEditADDRESS";
            this.textEditADDRESS.Size = new System.Drawing.Size(100, 21);
            this.textEditADDRESS.TabIndex = 32;
            this.textEditADDRESS.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.textEditADDRESS.EditValueChanged += new System.EventHandler(this.textEditADDRESS_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "出生日期";
            // 
            // dateTimePickerBIRTHDAY
            // 
            this.dateTimePickerBIRTHDAY.Location = new System.Drawing.Point(77, 84);
            this.dateTimePickerBIRTHDAY.MaxDate = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBIRTHDAY.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBIRTHDAY.Name = "dateTimePickerBIRTHDAY";
            this.dateTimePickerBIRTHDAY.Size = new System.Drawing.Size(102, 21);
            this.dateTimePickerBIRTHDAY.TabIndex = 33;
            this.dateTimePickerBIRTHDAY.Value = new System.DateTime(2008, 11, 7, 0, 0, 0, 0);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonADD);
            this.groupBoxEdit.Controls.Add(this.buttonModify);
            this.groupBoxEdit.Controls.Add(this.buttonDEL);
            this.groupBoxEdit.Controls.Add(this.buttonSELECTPIC);
            this.groupBoxEdit.Controls.Add(this.textEditPICPATH);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEdit.Location = new System.Drawing.Point(0, 154);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(1064, 45);
            this.groupBoxEdit.TabIndex = 34;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "编辑";
            // 
            // buttonSELECTPIC
            // 
            this.buttonSELECTPIC.Location = new System.Drawing.Point(643, 16);
            this.buttonSELECTPIC.Name = "buttonSELECTPIC";
            this.buttonSELECTPIC.Size = new System.Drawing.Size(75, 23);
            this.buttonSELECTPIC.TabIndex = 27;
            this.buttonSELECTPIC.Text = "选择照片";
            this.buttonSELECTPIC.UseVisualStyleBackColor = true;
            this.buttonSELECTPIC.Click += new System.EventHandler(this.buttonSELECTPIC_Click);
            // 
            // textEditPICPATH
            // 
            this.textEditPICPATH.Location = new System.Drawing.Point(742, 16);
            this.textEditPICPATH.Name = "textEditPICPATH";
            this.textEditPICPATH.Size = new System.Drawing.Size(182, 21);
            this.textEditPICPATH.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxMARK);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Controls.Add(this.checkBoxSHOWALL);
            this.groupBox2.Controls.Add(this.checkBoxCLEAR);
            this.groupBox2.Controls.Add(this.dateTimePickerBIRTHDAY);
            this.groupBox2.Controls.Add(this.radioGroupGENDER);
            this.groupBox2.Controls.Add(this.comboBoxEditTEAM);
            this.groupBox2.Controls.Add(this.textEditPHONE);
            this.groupBox2.Controls.Add(this.textEditNAME);
            this.groupBox2.Controls.Add(this.checkBoxPartyMember);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxEditGRADE);
            this.groupBox2.Controls.Add(this.checkBoxCadre);
            this.groupBox2.Controls.Add(this.comboBoxEditCLASS);
            this.groupBox2.Controls.Add(this.textEditID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textEditADDRESS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1064, 154);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "个人信息";
            // 
            // richTextBoxMARK
            // 
            this.richTextBoxMARK.Location = new System.Drawing.Point(497, 45);
            this.richTextBoxMARK.Name = "richTextBoxMARK";
            this.richTextBoxMARK.Size = new System.Drawing.Size(137, 103);
            this.richTextBoxMARK.TabIndex = 36;
            this.richTextBoxMARK.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(680, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(131, 132);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            // 
            // checkBoxSHOWALL
            // 
            this.checkBoxSHOWALL.AutoSize = true;
            this.checkBoxSHOWALL.Location = new System.Drawing.Point(876, 55);
            this.checkBoxSHOWALL.Name = "checkBoxSHOWALL";
            this.checkBoxSHOWALL.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSHOWALL.TabIndex = 34;
            this.checkBoxSHOWALL.Text = "显示所有";
            this.checkBoxSHOWALL.UseVisualStyleBackColor = true;
            this.checkBoxSHOWALL.CheckedChanged += new System.EventHandler(this.checkBoxSHOWALL_CheckedChanged);
            // 
            // checkBoxCLEAR
            // 
            this.checkBoxCLEAR.AutoSize = true;
            this.checkBoxCLEAR.Location = new System.Drawing.Point(876, 22);
            this.checkBoxCLEAR.Name = "checkBoxCLEAR";
            this.checkBoxCLEAR.Size = new System.Drawing.Size(72, 16);
            this.checkBoxCLEAR.TabIndex = 34;
            this.checkBoxCLEAR.Text = "清空所有";
            this.checkBoxCLEAR.UseVisualStyleBackColor = true;
            this.checkBoxCLEAR.CheckedChanged += new System.EventHandler(this.checkBoxCLEAR_CheckedChanged);
            // 
            // radioGroupGENDER
            // 
            this.radioGroupGENDER.Location = new System.Drawing.Point(79, 111);
            this.radioGroupGENDER.Name = "radioGroupGENDER";
            this.radioGroupGENDER.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.radioGroupGENDER.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupGENDER.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "男"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "女")});
            this.radioGroupGENDER.Size = new System.Drawing.Size(72, 26);
            this.radioGroupGENDER.TabIndex = 33;
            this.radioGroupGENDER.MouseEnter += new System.EventHandler(this.textEditID_MouseEnter);
            this.radioGroupGENDER.SelectedIndexChanged += new System.EventHandler(this.radioGroupGENDER_SelectedIndexChanged);
            // 
            // textEditPHONE
            // 
            this.textEditPHONE.Location = new System.Drawing.Point(279, 84);
            this.textEditPHONE.Name = "textEditPHONE";
            this.textEditPHONE.Size = new System.Drawing.Size(133, 21);
            this.textEditPHONE.TabIndex = 32;
            this.textEditPHONE.EditValueChanged += new System.EventHandler(this.textEditNAME_EditValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "年级";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(641, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "图片";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "联系方式";
            // 
            // CP_PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gridCtrl_StudentInfo);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBox2);
            this.Name = "CP_PersonInfo";
            this.Size = new System.Drawing.Size(1064, 702);
            this.Load += new System.EventHandler(this.CP_PersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl_StudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCLASS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTEAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGRADE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditADDRESS.Properties)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditPICPATH.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupGENDER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPHONE.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrl_StudentInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditCLASS;
        private DevExpress.XtraEditors.TextEdit textEditID;
        private DevExpress.XtraEditors.TextEdit textEditNAME;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.CheckBox checkBoxCadre;
        private System.Windows.Forms.CheckBox checkBoxPartyMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTEAM;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditGRADE;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditADDRESS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBIRTHDAY;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.RadioGroup radioGroupGENDER;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxCLEAR;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.RichTextBox richTextBoxMARK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSELECTPIC;
        private DevExpress.XtraEditors.TextEdit textEditPHONE;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditPICPATH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.CheckBox checkBoxSHOWALL;
        private System.Windows.Forms.Label label10;
    }
}
