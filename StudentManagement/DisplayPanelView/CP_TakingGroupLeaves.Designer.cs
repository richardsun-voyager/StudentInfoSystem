namespace StudentManagement
{
    partial class CP_TakingGroupLeaves
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
            this.gridControlGROUPLEAVES = new DevExpress.XtraGrid.GridControl();
            this.gridView2007 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEditGRADE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxMARK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelLeave = new System.Windows.Forms.Button();
            this.buttonCONFIRM = new System.Windows.Forms.Button();
            this.checkBoxSELECTALL = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTO = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFROM = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCancelLeave = new System.Windows.Forms.GroupBox();
            this.checkBoxCANCELALL = new System.Windows.Forms.CheckBox();
            this.buttonQUITLEAVE = new System.Windows.Forms.Button();
            this.buttonCANCELLEAVES = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTOTALCOUNT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSELECTCOUNT = new System.Windows.Forms.TextBox();
            this.checkBoxEXPANDALL = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSTAYPERSONCOUNT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSTAYSELECTCOUNT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOVERDATECOUNT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGROUPLEAVES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2007)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGRADE.Properties)).BeginInit();
            this.groupBoxCancelLeave.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlGROUPLEAVES
            // 
            this.gridControlGROUPLEAVES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGROUPLEAVES.EmbeddedNavigator.Name = "";
            this.gridControlGROUPLEAVES.Location = new System.Drawing.Point(0, 88);
            this.gridControlGROUPLEAVES.MainView = this.gridView2007;
            this.gridControlGROUPLEAVES.Name = "gridControlGROUPLEAVES";
            this.gridControlGROUPLEAVES.Size = new System.Drawing.Size(1049, 369);
            this.gridControlGROUPLEAVES.TabIndex = 5;
            this.gridControlGROUPLEAVES.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2007});
            // 
            // gridView2007
            // 
            this.gridView2007.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn17,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gridView2007.GridControl = this.gridControlGROUPLEAVES;
            this.gridView2007.GroupCount = 1;
            this.gridView2007.Name = "gridView2007";
            this.gridView2007.OptionsCustomization.AllowFilter = false;
            this.gridView2007.OptionsSelection.MultiSelect = true;
            this.gridView2007.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2007.OptionsView.ShowGroupPanel = false;
            this.gridView2007.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2007.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2007_FocusedRowChanged);
            this.gridView2007.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2007_SelectionChanged);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "区队";
            this.gridColumn9.FieldName = "TEAM";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Width = 56;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "班";
            this.gridColumn10.FieldName = "CLASS";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Width = 40;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "学号";
            this.gridColumn11.FieldName = "ID";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 81;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "姓名";
            this.gridColumn12.FieldName = "NAME";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 81;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "请/销假";
            this.gridColumn17.FieldName = "SELECT";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 2;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "请假日期";
            this.gridColumn13.FieldName = "LEAVEDATE";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 136;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "归假日期";
            this.gridColumn14.FieldName = "DUEDATE";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            this.gridColumn14.Width = 136;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "销假日期";
            this.gridColumn15.FieldName = "RETURNDATE";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "备注";
            this.gridColumn16.FieldName = "LEAVEMARK";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 6;
            this.gridColumn16.Width = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSTAYSELECTCOUNT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxEditGRADE);
            this.groupBox1.Controls.Add(this.textBoxSTAYPERSONCOUNT);
            this.groupBox1.Controls.Add(this.comboBoxMARK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonCancelLeave);
            this.groupBox1.Controls.Add(this.buttonCONFIRM);
            this.groupBox1.Controls.Add(this.checkBoxEXPANDALL);
            this.groupBox1.Controls.Add(this.checkBoxSELECTALL);
            this.groupBox1.Controls.Add(this.dateTimePickerTO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerFROM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "批处理请假";
            // 
            // comboBoxEditGRADE
            // 
            this.comboBoxEditGRADE.EditValue = "2007";
            this.comboBoxEditGRADE.Location = new System.Drawing.Point(71, 21);
            this.comboBoxEditGRADE.Name = "comboBoxEditGRADE";
            this.comboBoxEditGRADE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditGRADE.Properties.Items.AddRange(new object[] {
            "2007",
            "2008"});
            this.comboBoxEditGRADE.Size = new System.Drawing.Size(100, 23);
            this.comboBoxEditGRADE.TabIndex = 7;
            this.comboBoxEditGRADE.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditGRADE_SelectedIndexChanged);
            // 
            // comboBoxMARK
            // 
            this.comboBoxMARK.FormattingEnabled = true;
            this.comboBoxMARK.Items.AddRange(new object[] {
            "清明节",
            "五一节",
            "端午节",
            "暑假",
            "十一长假",
            "元旦",
            "春节"});
            this.comboBoxMARK.Location = new System.Drawing.Point(534, 22);
            this.comboBoxMARK.Name = "comboBoxMARK";
            this.comboBoxMARK.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMARK.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "备注";
            // 
            // buttonCancelLeave
            // 
            this.buttonCancelLeave.Location = new System.Drawing.Point(800, 20);
            this.buttonCancelLeave.Name = "buttonCancelLeave";
            this.buttonCancelLeave.Size = new System.Drawing.Size(69, 23);
            this.buttonCancelLeave.TabIndex = 4;
            this.buttonCancelLeave.Text = "销假";
            this.buttonCancelLeave.UseVisualStyleBackColor = true;
            this.buttonCancelLeave.Click += new System.EventHandler(this.buttonCancelLeave_Click);
            // 
            // buttonCONFIRM
            // 
            this.buttonCONFIRM.Location = new System.Drawing.Point(689, 20);
            this.buttonCONFIRM.Name = "buttonCONFIRM";
            this.buttonCONFIRM.Size = new System.Drawing.Size(75, 23);
            this.buttonCONFIRM.TabIndex = 4;
            this.buttonCONFIRM.Text = "确定";
            this.buttonCONFIRM.UseVisualStyleBackColor = true;
            this.buttonCONFIRM.Click += new System.EventHandler(this.buttonCONFIRM_Click);
            // 
            // checkBoxSELECTALL
            // 
            this.checkBoxSELECTALL.AutoSize = true;
            this.checkBoxSELECTALL.Location = new System.Drawing.Point(935, 23);
            this.checkBoxSELECTALL.Name = "checkBoxSELECTALL";
            this.checkBoxSELECTALL.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSELECTALL.TabIndex = 1;
            this.checkBoxSELECTALL.Text = "默认全选";
            this.checkBoxSELECTALL.UseVisualStyleBackColor = true;
            this.checkBoxSELECTALL.CheckedChanged += new System.EventHandler(this.checkBoxSELECTALL_CheckedChanged);
            // 
            // dateTimePickerTO
            // 
            this.dateTimePickerTO.Location = new System.Drawing.Point(371, 22);
            this.dateTimePickerTO.Name = "dateTimePickerTO";
            this.dateTimePickerTO.Size = new System.Drawing.Size(108, 21);
            this.dateTimePickerTO.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "年级";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "起止时间";
            // 
            // dateTimePickerFROM
            // 
            this.dateTimePickerFROM.Location = new System.Drawing.Point(255, 22);
            this.dateTimePickerFROM.Name = "dateTimePickerFROM";
            this.dateTimePickerFROM.Size = new System.Drawing.Size(110, 21);
            this.dateTimePickerFROM.TabIndex = 2;
            // 
            // groupBoxCancelLeave
            // 
            this.groupBoxCancelLeave.Controls.Add(this.textBoxSELECTCOUNT);
            this.groupBoxCancelLeave.Controls.Add(this.label5);
            this.groupBoxCancelLeave.Controls.Add(this.textBoxOVERDATECOUNT);
            this.groupBoxCancelLeave.Controls.Add(this.label8);
            this.groupBoxCancelLeave.Controls.Add(this.textBoxTOTALCOUNT);
            this.groupBoxCancelLeave.Controls.Add(this.label4);
            this.groupBoxCancelLeave.Controls.Add(this.checkBoxCANCELALL);
            this.groupBoxCancelLeave.Controls.Add(this.buttonQUITLEAVE);
            this.groupBoxCancelLeave.Controls.Add(this.buttonCANCELLEAVES);
            this.groupBoxCancelLeave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxCancelLeave.Location = new System.Drawing.Point(0, 457);
            this.groupBoxCancelLeave.Name = "groupBoxCancelLeave";
            this.groupBoxCancelLeave.Size = new System.Drawing.Size(1049, 57);
            this.groupBoxCancelLeave.TabIndex = 6;
            this.groupBoxCancelLeave.TabStop = false;
            this.groupBoxCancelLeave.Text = "销假";
            this.groupBoxCancelLeave.Visible = false;
            // 
            // checkBoxCANCELALL
            // 
            this.checkBoxCANCELALL.AutoSize = true;
            this.checkBoxCANCELALL.Location = new System.Drawing.Point(26, 22);
            this.checkBoxCANCELALL.Name = "checkBoxCANCELALL";
            this.checkBoxCANCELALL.Size = new System.Drawing.Size(72, 16);
            this.checkBoxCANCELALL.TabIndex = 2;
            this.checkBoxCANCELALL.Text = "默认全选";
            this.checkBoxCANCELALL.UseVisualStyleBackColor = true;
            this.checkBoxCANCELALL.CheckedChanged += new System.EventHandler(this.checkBoxCANCELALL_CheckedChanged);
            // 
            // buttonQUITLEAVE
            // 
            this.buttonQUITLEAVE.Location = new System.Drawing.Point(884, 20);
            this.buttonQUITLEAVE.Name = "buttonQUITLEAVE";
            this.buttonQUITLEAVE.Size = new System.Drawing.Size(75, 23);
            this.buttonQUITLEAVE.TabIndex = 4;
            this.buttonQUITLEAVE.Text = "退出销假";
            this.buttonQUITLEAVE.UseVisualStyleBackColor = true;
            this.buttonQUITLEAVE.Click += new System.EventHandler(this.buttonQUIT_Click);
            // 
            // buttonCANCELLEAVES
            // 
            this.buttonCANCELLEAVES.Location = new System.Drawing.Point(764, 20);
            this.buttonCANCELLEAVES.Name = "buttonCANCELLEAVES";
            this.buttonCANCELLEAVES.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCELLEAVES.TabIndex = 4;
            this.buttonCANCELLEAVES.Text = "确定销假";
            this.buttonCANCELLEAVES.UseVisualStyleBackColor = true;
            this.buttonCANCELLEAVES.Click += new System.EventHandler(this.buttonCANCELLEAVES_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "待销假人数";
            // 
            // textBoxTOTALCOUNT
            // 
            this.textBoxTOTALCOUNT.Location = new System.Drawing.Point(405, 22);
            this.textBoxTOTALCOUNT.Name = "textBoxTOTALCOUNT";
            this.textBoxTOTALCOUNT.Size = new System.Drawing.Size(100, 21);
            this.textBoxTOTALCOUNT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "选中人数";
            // 
            // textBoxSELECTCOUNT
            // 
            this.textBoxSELECTCOUNT.Location = new System.Drawing.Point(612, 22);
            this.textBoxSELECTCOUNT.Name = "textBoxSELECTCOUNT";
            this.textBoxSELECTCOUNT.Size = new System.Drawing.Size(100, 21);
            this.textBoxSELECTCOUNT.TabIndex = 6;
            // 
            // checkBoxEXPANDALL
            // 
            this.checkBoxEXPANDALL.AutoSize = true;
            this.checkBoxEXPANDALL.Location = new System.Drawing.Point(51, 58);
            this.checkBoxEXPANDALL.Name = "checkBoxEXPANDALL";
            this.checkBoxEXPANDALL.Size = new System.Drawing.Size(72, 16);
            this.checkBoxEXPANDALL.TabIndex = 1;
            this.checkBoxEXPANDALL.Text = "展开所有";
            this.checkBoxEXPANDALL.UseVisualStyleBackColor = true;
            this.checkBoxEXPANDALL.CheckedChanged += new System.EventHandler(this.checkBoxEXPANDALL_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "在位人数";
            // 
            // textBoxSTAYPERSONCOUNT
            // 
            this.textBoxSTAYPERSONCOUNT.Location = new System.Drawing.Point(255, 56);
            this.textBoxSTAYPERSONCOUNT.Name = "textBoxSTAYPERSONCOUNT";
            this.textBoxSTAYPERSONCOUNT.Size = new System.Drawing.Size(100, 21);
            this.textBoxSTAYPERSONCOUNT.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "选中人数";
            // 
            // textBoxSTAYSELECTCOUNT
            // 
            this.textBoxSTAYSELECTCOUNT.Location = new System.Drawing.Point(479, 56);
            this.textBoxSTAYSELECTCOUNT.Name = "textBoxSTAYSELECTCOUNT";
            this.textBoxSTAYSELECTCOUNT.Size = new System.Drawing.Size(100, 21);
            this.textBoxSTAYSELECTCOUNT.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "待销假人数";
            // 
            // textBoxOVERDATECOUNT
            // 
            this.textBoxOVERDATECOUNT.Location = new System.Drawing.Point(218, 22);
            this.textBoxOVERDATECOUNT.Name = "textBoxOVERDATECOUNT";
            this.textBoxOVERDATECOUNT.Size = new System.Drawing.Size(100, 21);
            this.textBoxOVERDATECOUNT.TabIndex = 6;
            // 
            // CP_TakingGroupLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlGROUPLEAVES);
            this.Controls.Add(this.groupBoxCancelLeave);
            this.Controls.Add(this.groupBox1);
            this.Name = "CP_TakingGroupLeaves";
            this.Size = new System.Drawing.Size(1049, 514);
            this.Load += new System.EventHandler(this.CP_TakingLeavesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGROUPLEAVES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2007)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGRADE.Properties)).EndInit();
            this.groupBoxCancelLeave.ResumeLayout(false);
            this.groupBoxCancelLeave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSELECTALL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTO;
        private System.Windows.Forms.DateTimePicker dateTimePickerFROM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCONFIRM;
        private DevExpress.XtraGrid.GridControl gridControlGROUPLEAVES;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2007;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMARK;
        private System.Windows.Forms.Button buttonCancelLeave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.GroupBox groupBoxCancelLeave;
        private System.Windows.Forms.CheckBox checkBoxCANCELALL;
        private System.Windows.Forms.Button buttonQUITLEAVE;
        private System.Windows.Forms.Button buttonCANCELLEAVES;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditGRADE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSELECTCOUNT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTOTALCOUNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxEXPANDALL;
        private System.Windows.Forms.TextBox textBoxSTAYSELECTCOUNT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSTAYPERSONCOUNT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOVERDATECOUNT;
        private System.Windows.Forms.Label label8;

    }
}
