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
    /// �������
    /// </summary>
    public partial class CP_TakingGroupLeaves : UserControl
    {
        public CP_TakingGroupLeaves()
        {
            InitializeComponent();
        }

        #region ��������
        /// <summary>
        /// ������Ϣ��
        /// </summary>
        private PersonInfo personInfo;
        /// <summary>
        /// �����Ϣ��
        /// </summary>
        private LeaveInfo leaveInfo;
        /// <summary>
        /// ���ݱ�
        /// </summary>
        private DataTable dt;
        /// <summary>
        /// �Ƿ�������״̬
        /// </summary>
        private bool IsCancelLeaveState;
        #endregion

        #region ��������
        /// <summary>
        /// ѡ��ȫ��
        /// </summary>
        /// <param name="IsSelected"></param>
        private void SetState(bool IsSelected)
        {
            for(int i=0;i<gridView2007.RowCount;i++)
                gridView2007.SetRowCellValue(i,gridColumn17, IsSelected);

        }
        /// <summary>
        /// //������Ϊ��Ա�������
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
        /// //���������Ա�������
        /// </summary>
        private void UpdateAwayPersonDataTable()
        {
            dt = personInfo.GetAwayPersonInfoTable(comboBoxEditGRADE.Text);
            dt.Columns.Add("SELECT", typeof(bool));
            gridControlGROUPLEAVES.DataSource = dt;
        }
        #endregion

        #region �¼���������
        /// <summary>
        /// �����ʼ��
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
        /// �л�������״̬
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
        /// �˳�����״̬
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
        /// �������ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2007_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
             string s = gridView2007.GetFocusedRowCellDisplayText(gridColumn17);
            //���з�ѡ
            //������״̬
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
        /// ѡ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSELECTALL_CheckedChanged(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//��ȡѡ�е��б�
            if (rowcount >0)//ѡ����ѡ����
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
        ///  //�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCONFIRM_Click(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//��ȡѡ�е��б�
            
            if (rowcount > 0)//ѡ����ѡ����
            {
                for (int i = 0; i < rowcount-1; i++)
                {
                    string s= gridView2007.GetRowCellDisplayText(i,gridColumn17);
                    if (s=="Checked")//�Ƿ�ѡ��
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
        /// //��ѡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2007_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int[] indices = gridView2007.GetSelectedRows();//��ȡѡ�е��б�
            if (indices != null)//ѡ����ѡ����
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
        /// ѡ��ȫ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxCANCELALL_CheckedChanged(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//��ȡѡ�е��б�
            if (rowcount > 0)//ѡ����ѡ����
            {
                for (int i = 0; i < rowcount; i++)
                {
                    gridView2007.SetRowCellValue(i, gridColumn17, checkBoxCANCELALL.Checked);
                    gridView2007.SetRowCellValue(i, gridColumn15, DateTime.Now);


                }
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCANCELLEAVES_Click(object sender, EventArgs e)
        {
            int rowcount = gridView2007.RowCount;//��ȡѡ�е��б�

            if (rowcount > 0)//ѡ����ѡ����
            {
                for (int i = 0; i < rowcount - 1; i++)
                {
                    string s = gridView2007.GetRowCellDisplayText(i, gridColumn17);
                    if (s == "Checked")//�Ƿ�ѡ��
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
        /// ѡ���꼶
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
        /// չ��������
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
