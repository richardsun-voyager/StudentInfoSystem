namespace StudentManagement
{
    partial class frmPersonInfo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxPartyMember = new System.Windows.Forms.CheckBox();
            this.checkBoxCadre = new System.Windows.Forms.CheckBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.comboBoxEditCLASS = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditTEAM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridCtrl_StudentInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.textEditNAME = new DevExpress.XtraEditors.TextEdit();
            this.buttonDEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCLASS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTEAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl_StudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNAME.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "区队：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "班：";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "一区队";
            this.comboBoxEdit1.Location = new System.Drawing.Point(118, 96);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "一区队",
            "二区队",
            "三区队",
            "四区队",
            "五区队",
            "六区队"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(343, 96);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEdit2.TabIndex = 2;
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(100, 138);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "党员";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 3;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(343, 138);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "骨干";
            this.checkEdit2.Size = new System.Drawing.Size(75, 19);
            this.checkEdit2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "学号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "区队";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "班级";
            // 
            // checkBoxPartyMember
            // 
            this.checkBoxPartyMember.AutoSize = true;
            this.checkBoxPartyMember.Checked = true;
            this.checkBoxPartyMember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPartyMember.Location = new System.Drawing.Point(133, 138);
            this.checkBoxPartyMember.Name = "checkBoxPartyMember";
            this.checkBoxPartyMember.Size = new System.Drawing.Size(48, 16);
            this.checkBoxPartyMember.TabIndex = 3;
            this.checkBoxPartyMember.Text = "党员";
            this.checkBoxPartyMember.UseVisualStyleBackColor = true;
            // 
            // checkBoxCadre
            // 
            this.checkBoxCadre.AutoSize = true;
            this.checkBoxCadre.Location = new System.Drawing.Point(273, 138);
            this.checkBoxCadre.Name = "checkBoxCadre";
            this.checkBoxCadre.Size = new System.Drawing.Size(48, 16);
            this.checkBoxCadre.TabIndex = 3;
            this.checkBoxCadre.Text = "骨干";
            this.checkBoxCadre.UseVisualStyleBackColor = true;
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(59, 178);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 4;
            this.buttonADD.Text = "添加学员";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(325, 178);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(442, 178);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 4;
            this.buttonCANCEL.Text = "取消";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // comboBoxEditCLASS
            // 
            this.comboBoxEditCLASS.Location = new System.Drawing.Point(325, 97);
            this.comboBoxEditCLASS.Name = "comboBoxEditCLASS";
            this.comboBoxEditCLASS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditCLASS.Properties.Mask.EditMask = "d8";
            this.comboBoxEditCLASS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.comboBoxEditCLASS.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEditCLASS.TabIndex = 5;
            // 
            // comboBoxEditTEAM
            // 
            this.comboBoxEditTEAM.EditValue = "一区队";
            this.comboBoxEditTEAM.Location = new System.Drawing.Point(111, 97);
            this.comboBoxEditTEAM.Name = "comboBoxEditTEAM";
            this.comboBoxEditTEAM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditTEAM.Properties.Items.AddRange(new object[] {
            "一区队",
            "二区队",
            "三区队",
            "四区队",
            "五区队",
            "六区队"});
            this.comboBoxEditTEAM.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEditTEAM.TabIndex = 5;
            this.comboBoxEditTEAM.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditTEAM_SelectedIndex);
            // 
            // gridCtrl_StudentInfo
            // 
            this.gridCtrl_StudentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCtrl_StudentInfo.EmbeddedNavigator.Name = "";
            this.gridCtrl_StudentInfo.Location = new System.Drawing.Point(0, 238);
            this.gridCtrl_StudentInfo.MainView = this.gridView1;
            this.gridCtrl_StudentInfo.Name = "gridCtrl_StudentInfo";
            this.gridCtrl_StudentInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridCtrl_StudentInfo.Size = new System.Drawing.Size(699, 307);
            this.gridCtrl_StudentInfo.TabIndex = 6;
            this.gridCtrl_StudentInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridCtrl_StudentInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "学号";
            this.gridColumn1.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
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
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "班";
            this.gridColumn3.FieldName = "CLASS";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "区队";
            this.gridColumn4.FieldName = "TEAM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "是否党员";
            this.gridColumn5.FieldName = "IsPartyMember";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "是否骨干";
            this.gridColumn6.FieldName = "IsCadre";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(111, 54);
            this.textEditID.Name = "textEditID";
            this.textEditID.Properties.Mask.BeepOnError = true;
            this.textEditID.Properties.Mask.EditMask = "d8";
            this.textEditID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditID.Size = new System.Drawing.Size(100, 21);
            this.textEditID.TabIndex = 7;
            // 
            // textEditNAME
            // 
            this.textEditNAME.Location = new System.Drawing.Point(325, 54);
            this.textEditNAME.Name = "textEditNAME";
            this.textEditNAME.Size = new System.Drawing.Size(100, 21);
            this.textEditNAME.TabIndex = 7;
            // 
            // buttonDEL
            // 
            this.buttonDEL.Enabled = false;
            this.buttonDEL.Location = new System.Drawing.Point(189, 178);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(75, 23);
            this.buttonDEL.TabIndex = 4;
            this.buttonDEL.Text = "删除";
            this.buttonDEL.UseVisualStyleBackColor = true;
            // 
            // frmPersonInfo
            // 
            this.ClientSize = new System.Drawing.Size(699, 545);
            this.Controls.Add(this.textEditNAME);
            this.Controls.Add(this.textEditID);
            this.Controls.Add(this.gridCtrl_StudentInfo);
            this.Controls.Add(this.comboBoxEditTEAM);
            this.Controls.Add(this.comboBoxEditCLASS);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDEL);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.checkBoxCadre);
            this.Controls.Add(this.checkBoxPartyMember);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "frmPersonInfo";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.frmPersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCLASS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTEAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl_StudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNAME.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxPartyMember;
        private System.Windows.Forms.CheckBox checkBoxCadre;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCANCEL;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditCLASS;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTEAM;
        private DevExpress.XtraGrid.GridControl gridCtrl_StudentInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.TextEdit textEditID;
        private DevExpress.XtraEditors.TextEdit textEditNAME;
        private System.Windows.Forms.Button buttonDEL;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}