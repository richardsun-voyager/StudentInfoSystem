namespace StudentManagement
{
    partial class frmSysConfig
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
            this.checkBoxTIMERENABLE = new System.Windows.Forms.CheckBox();
            this.comboBoxTIMEINTERVAL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCONFIRM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxTIMERENABLE
            // 
            this.checkBoxTIMERENABLE.AutoSize = true;
            this.checkBoxTIMERENABLE.Location = new System.Drawing.Point(42, 30);
            this.checkBoxTIMERENABLE.Name = "checkBoxTIMERENABLE";
            this.checkBoxTIMERENABLE.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTIMERENABLE.TabIndex = 0;
            this.checkBoxTIMERENABLE.Text = "定时提醒";
            this.checkBoxTIMERENABLE.UseVisualStyleBackColor = true;
            this.checkBoxTIMERENABLE.CheckedChanged += new System.EventHandler(this.checkBoxTIMERENABLE_CheckedChanged);
            // 
            // comboBoxTIMEINTERVAL
            // 
            this.comboBoxTIMEINTERVAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTIMEINTERVAL.FormattingEnabled = true;
            this.comboBoxTIMEINTERVAL.Items.AddRange(new object[] {
            "1小时",
            "2小时",
            "3小时",
            "6小时"});
            this.comboBoxTIMEINTERVAL.Location = new System.Drawing.Point(124, 73);
            this.comboBoxTIMEINTERVAL.Name = "comboBoxTIMEINTERVAL";
            this.comboBoxTIMEINTERVAL.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTIMEINTERVAL.TabIndex = 1;
            this.comboBoxTIMEINTERVAL.SelectedIndexChanged += new System.EventHandler(this.comboBoxTIMEINTERVAL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "时间间隔";
            // 
            // buttonCONFIRM
            // 
            this.buttonCONFIRM.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCONFIRM.Location = new System.Drawing.Point(103, 122);
            this.buttonCONFIRM.Name = "buttonCONFIRM";
            this.buttonCONFIRM.Size = new System.Drawing.Size(75, 23);
            this.buttonCONFIRM.TabIndex = 3;
            this.buttonCONFIRM.Text = "确定";
            this.buttonCONFIRM.UseVisualStyleBackColor = true;
            // 
            // sysConfigFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 169);
            this.Controls.Add(this.buttonCONFIRM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTIMEINTERVAL);
            this.Controls.Add(this.checkBoxTIMERENABLE);
            this.Name = "sysConfigFrame";
            this.Text = "系统设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTIMERENABLE;
        private System.Windows.Forms.ComboBox comboBoxTIMEINTERVAL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCONFIRM;
    }
}