using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CP_StudentPunishmentRecords : UserControl
    {
        public CP_StudentPunishmentRecords(bool isEditable)
        {
            InitializeComponent();
            IsEditable = isEditable;
        }

        #region 变量声明
        /// <summary>
        /// 是否可编辑
        /// </summary>
        private bool IsEditable;
        /// <summary>
        /// 处罚类
        /// </summary>
        private Punishment punishment;
        /// <summary>
        /// 个人信息类
        /// </summary>
        private PersonInfo personInfo;
        /// <summary>
        /// 判断鼠标是否在表格上
        /// </summary>
        private bool IsQuery;
        #endregion

        #region 成员函数区
        /// <summary>
        /// 显示学生信息
        /// </summary>
        /// <param name="dt"></param>
        private void FillStudentInfoDatatable(DataTable dt)
        {
            gridControlSTUDENTINFO.DataSource = dt; 
            gridView2.ExpandAllGroups();
        }
        /// <summary>
        /// 显示处罚信息
        /// </summary>
        /// <param name="dt"></param>
        private void FillPunishRecordsDatatable(DataTable dt)
        {
            gridControlPUNISHRECORDS.DataSource = dt;
            gridView1.ExpandAllGroups();
            textEditQUANTITIZE.Text = Statistic("量化", gridColumn6).ToString();
            textEditERROR.Text = Statistic("记过", gridColumn6).ToString();
           textEditWARNING.Text = Statistic("警告", gridColumn6).ToString();
           textEditPARTYNUM.Text = Statistic("True", gridColumn4).ToString();
        }
        /// <summary>
        /// 跟新处罚信息表格
        /// </summary>
        private void UpdatePunishDataTable()
        {
            FillPunishRecordsDatatable(punishment.GetPunishmentDataTable());
        }
        /// <summary>
        /// 统计处罚信息
        /// </summary>
        /// <param name="punishtype"></param>
        /// <param name="gridColumn"></param>
        /// <returns></returns>
        private int Statistic(string punishtype,DevExpress.XtraGrid.Columns.GridColumn gridColumn)
        {
            int count = 0;
            int RowsCount = gridView1.RowCount;
            for (int i = 0; i < RowsCount; i++)
            {
                string strTemp = gridView1.GetRowCellValue(i, gridColumn).ToString();
                if (strTemp == punishtype)
                    count++;
            }
            return count;
        }
        /// <summary>
        /// 判断处罚种类
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        private int JudgeTypeIndex(string action)
        {
            int index = -1;
            switch (action)
            {
                case "量化":
                    index=0;break;
                case "记过":
                    index =1;break;
                case "警告":
                    index=2;break;
                default:
                    index=3;break;
            }
            return index;
        }
        #endregion

        #region 事件函数
        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CP_StudentPunishmentRecords_Load(object sender, EventArgs e)
        {
            IsQuery = false;
            panelEDIT.Visible = IsEditable;
            punishment = new Punishment();
            personInfo = new PersonInfo();
            FillStudentInfoDatatable(personInfo.GetPersonInfoTable());
            FillPunishRecordsDatatable(punishment.GetPunishmentDataTable());
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonADDRECORD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定处罚该学员?","确认",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    punishment = new Punishment();
                    punishment.nID = textEditID.Text;
                    punishment.Punishement = radioGroupPUNITSHTYPE.Properties.Items[radioGroupPUNITSHTYPE.SelectedIndex].Description;
                    punishment.AuthorizeUnit = comboBoxUNIT.Text;
                    punishment.ExeDateTime = dateTimePickerDATETIME.Value.Date;
                    punishment.Reason = richTextBoxREASON.Text;
                    punishment.InsertPunishRecord(punishment);
                    DataTable dt = punishment.QueryPunishRecordDataTable(textEditID.Text);
                    FillPunishRecordsDatatable(dt);
                    //UpdatePunishDataTable();
                }
                catch
                {
                    MessageBox.Show("插入有误!");
                }
            }
        }
        
        /// <summary>
        /// 鼠标单击该行时显示该行信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IsQuery = false;
                string nID = gridView2.GetFocusedRowCellDisplayText(gridColumn1);
                textEditID.Text = nID;
                textBoxNAME.Text = gridView2.GetFocusedRowCellDisplayText(gridColumn13);
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// 鼠标单击表格时显示表格内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IsQuery = false;
                 string nID = gridView1.GetFocusedRowCellDisplayText(gridColumn1);
                textEditID.Text = nID;
                textBoxNAME.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn13);
                comboBoxUNIT.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn7);
                radioGroupPUNITSHTYPE.SelectedIndex = JudgeTypeIndex(gridView1.GetFocusedRowCellDisplayText(gridColumn6));
                richTextBoxREASON.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn9);
                if(gridView1.GetFocusedRowCellDisplayText(gridColumn8)!="")
                   dateTimePickerDATETIME.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(gridColumn8));
            }
            catch
            {
                MessageBox.Show("数据不正确！");
            }
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDELETERECORD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定取消该学员记录?", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                punishment.DeletePunishRecord(textEditID.Text);
                UpdatePunishDataTable();
            }
        }
        /// <summary>
        /// 动态查询个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNAME_TextChanged(object sender, EventArgs e)
        {
            if (IsQuery)
            {
                DataTable dt = personInfo.QueryPersonInfoDatatable(textBoxNAME.Text);
                FillStudentInfoDatatable(dt);
        
            }
        }
        private void textBoxNAME_MouseEnter(object sender, EventArgs e)
        {
            IsQuery = true;
        }
        /// <summary>
        /// 展开所有表格信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEXPANDALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEXPANDALL.Checked)
            {
                gridView1.ExpandAllGroups();
                gridView2.ExpandAllGroups();
            }
            else
            {
                gridView1.CollapseAllGroups();
                gridView2.CollapseAllGroups();
            }
        }
        /// <summary>
        /// 显示所有表格信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSHOWALL_CheckedChanged(object sender, EventArgs e)
        {
            FillStudentInfoDatatable(personInfo.GetPersonInfoTable());
            FillPunishRecordsDatatable(punishment.GetPunishmentDataTable());
        }
        /// <summary>
        /// 查询个人违纪记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQUERY_Click(object sender, EventArgs e)
        {
            DataTable dt = punishment.QueryPunishRecordDataTable(textBoxNAME.Text);
            FillPunishRecordsDatatable(dt);
        }
        #endregion

        private void buttonMODIFYRECORD_Click(object sender, EventArgs e)
        {
            punishment = new Punishment();
            punishment.nID = textEditID.Text;
            punishment.Punishement = radioGroupPUNITSHTYPE.Properties.Items[radioGroupPUNITSHTYPE.SelectedIndex].Description;
            punishment.AuthorizeUnit = comboBoxUNIT.Text;
            punishment.ExeDateTime = dateTimePickerDATETIME.Value.Date;
            punishment.Reason = richTextBoxREASON.Text;
            punishment.ModifyPunishRecord(textEditID.Text,punishment);
            UpdatePunishDataTable();
        }


    }
}
