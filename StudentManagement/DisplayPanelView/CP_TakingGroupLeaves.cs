using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    /// <summary>
    /// 集体请假
    /// </summary>
    public partial class CP_TakingGroupLeaves : UserControl
    {
        public CP_TakingGroupLeaves()
        {
            InitializeComponent();
        }

        #region 变量声明
        /// <summary>
        /// 个人信息类
        /// </summary>
        private PersonInfo personInfo;
        /// <summary>
        /// 请假信息类
        /// </summary>
        private LeaveInfo leaveInfo;
        /// <summary>
        /// 数据表
        /// </summary>
        private DataTable dt;
        /// <summary>
        /// 是否是销假状态
        /// </summary>
        private bool IsCancelLeaveState;
        #endregion

        #region 函数定义
        /// <summary>
        /// 选中全部
        /// </summary>
        /// <param name="IsSelected"></param>
        private void SetState(bool IsSelected)
        {
            for(int i=0;i<gridView2007.RowCount;i++)
                gridView2007.SetRowCellValue(i,gridColumn17, IsSelected);

        }
        /// <summary>
        /// //更新在为人员表格内容
        /// </summary>
        private void UpdateStayPersonDataTable()
        {
            dt = personInfo.GetStayPersonInfoTable(comboBoxEditGRADE.Text);
            dt.Columns.Add("SELECT",typeof(bool));
            dt.Columns.Add("LEAVEDATE", typeof(DateTime));
            dt.Columns.Add("DUEDATE", typeof(DateTime));
            dt.Columns.Add("LEAVEMARK", typeof(string));
            gridControlGROUPLEAVES.DataSource = dt;
        }
        /// <summary>
        /// //更新离队人员表格内容
        /// </summary>
        private void UpdateAwayPersonDataTable()
        {
            dt = personInfo.GetAwayPersonInfoTable(comboBoxEditGRADE.Text);
            dt.Columns.Add("SELECT", typeof(bool));
            gridControlGROUPLEAVES.DataSource = dt;
        }
        #endregion

        #region 事件函数定义
        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CP_TakingLeavesLoad(object sender, EventArgs e)
        {
            personInfo = new PersonInfo();
            UpdateStayPersonDataTable();
            IsCancelLeaveState = false;
            gridView2007.ExpandAllGroups();
        }
        /// <summary>
        /// 切换至销假状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelLeave_Click(object sender, EventArgs e)
        {
            this.groupBoxCancelLeave.Visible = true;
            IsCancelLeaveState = true;
            UpdateAwayPersonDataTable();

        }
        /// <summary>
        /// 退出销假状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQUIT_Click(object sender, EventArgs e)
        {
            this.groupBoxCancelLeave.Visible = false;
            IsCancelLeaveState = false;
            UpdateStayPersonDataTable();
        }
        /// <summary>
        /// 但及表格选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2007_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
             string s = gridView2007.GetFocusedRowCellDisplayText(gridColumn17);
            //进行反选
            //非销假状态
             if (!IsCancelLeaveState)
             {
                 if (s == "Checked")
                 {
                     gridView2007.SetFocusedRowCellValue(gridColumn17, true);
                     gridView2007.SetFocusedRowCellValue(gridColumn13, dateTimePickerFROM.Value);
                     gridView2007.SetFocusedRowCellValue(gridColumn14, dateTimePickerTO.Value);
                     gridView2007.SetFocusedRowCellValue(gridColumn16, comboBoxMARK.Text);
                 }
                 else
                 {
                     gridView2007.SetFocusedRowCellValue(gridColumn17, false);
                     gridView2007.SetFocusedRowCellValue(gridColumn13, null);
                     gridView2007.SetFocusedRowCellValue(gridColumn14, null);
                     gridView2007.SetFocusedRowCellValue(gridColumn16, null);
                 }
             }
             else
             {
                 if (s == "Checked")
                 {
                     gridView2007.SetFocusedRowCellValue(gridColumn17, true);
                     gridView2007.SetFocusedRowCellValue(gridColumn15, DateTime.Now);
                 }
                 else
                 {
                     gridView2007.SetFocusedRowCellValue(gridColumn17, false);
                     gridView2007.SetFocusedRowCellValue(gridColumn15, DateTime.Now);
                 }
             }
        }

        /// <summary>
        /// 选中所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSELECTALL_CheckedChanged(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//获取选中的行标
            if (rowcount >0)//选中所选的行
            {
                for (int i = 0; i < rowcount; i++)
                {
                    gridView2007.SetRowCellValue(i, gridColumn17, checkBoxSELECTALL.Checked);
                    gridView2007.SetRowCellValue(i, gridColumn13, dateTimePickerFROM.Value);
                    gridView2007.SetRowCellValue(i, gridColumn14, dateTimePickerTO.Value);
                    gridView2007.SetRowCellValue(i, gridColumn16, comboBoxMARK.Text);
                
                }
            }
        }
        /// <summary>
        ///  //批量请假
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCONFIRM_Click(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//获取选中的行标
            
            if (rowcount > 0)//选中所选的行
            {
                for (int i = 0; i < rowcount-1; i++)
                {
                    string s= gridView2007.GetRowCellDisplayText(i,gridColumn17);
                    if (s=="Checked")//是否被选中
                    {
                        leaveInfo = new LeaveInfo();
                        leaveInfo.nID = gridView2007.GetRowCellDisplayText(i,gridColumn11);
                        leaveInfo.tLEAVEDATE = dateTimePickerFROM.Value;
                        leaveInfo.tDUEDATE = dateTimePickerTO.Value;
                        leaveInfo.strReason = comboBoxMARK.Text;
                        leaveInfo.InsertLeaveRecord(leaveInfo);
                    }
                }
                UpdateStayPersonDataTable();
            }
        }
        /// <summary>
        /// //框选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2007_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int[] indices = gridView2007.GetSelectedRows();//获取选中的行标
            if (indices != null)//选中所选的行
            {
                for (int i = 0; i < indices.GetLength(0); i++)
                {
                    if (indices[i] >= 0)
                    {
                        gridView2007.SetRowCellValue(indices[i], gridColumn17, false);
                        if (!IsCancelLeaveState)
                        {
                            gridView2007.SetRowCellValue(indices[i], gridColumn13, dateTimePickerFROM.Value);
                            gridView2007.SetRowCellValue(indices[i], gridColumn14, dateTimePickerTO.Value);
                            gridView2007.SetRowCellValue(indices[i], gridColumn16, comboBoxMARK.Text);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 选定全部销假
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxCANCELALL_CheckedChanged(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//获取选中的行标
            if (rowcount > 0)//选中所选的行
            {
                for (int i = 0; i < rowcount; i++)
                {
                    gridView2007.SetRowCellValue(i, gridColumn17, checkBoxCANCELALL.Checked);
                    gridView2007.SetRowCellValue(i, gridColumn15, DateTime.Now);


                }
            }
        }
        /// <summary>
        /// 销假
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCANCELLEAVES_Click(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//获取选中的行标

            if (rowcount > 0)//选中所选的行
            {
                for (int i = 0; i < rowcount - 1; i++)
                {
                    string s = gridView2007.GetRowCellDisplayText(i, gridColumn17);
                    if (s == "Checked")//是否被选中
                    {
                        leaveInfo = new LeaveInfo();
                         string text=  gridView2007.GetRowCellDisplayText(i, gridColumn11);
                        leaveInfo.CancelLeaveRecord(text);
                    }
                }
                UpdateAwayPersonDataTable();
            }
        }
        /// <summary>
        /// 选择年级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEditGRADE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsCancelLeaveState)
                UpdateStayPersonDataTable();
            else
                UpdateAwayPersonDataTable();
        }
        /// <summary>
        /// 展开所有组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEXPANDALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEXPANDALL.Checked)
                gridView2007.ExpandAllGroups();
            else
                gridView2007.CollapseAllGroups();
        }
        #endregion
    }
}
