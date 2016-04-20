using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace StudentManagement
{
    public partial class CP_PersonLeave : UserControl
    {
        public CP_PersonLeave()
        {
            InitializeComponent();
        }
        private DBConnection db = new DBConnection();
        private OleDbConnection oleConn = new OleDbConnection();
        private LeaveInfo LeaveInfo;
        private PersonInfo personInfo;
        private bool bFlags = false;
        private void CP_PersonLeave_Load(object sender, EventArgs e)
        {
            LeaveInfo = new LeaveInfo();
            gridControlLEAVES.DataSource = LeaveInfo.GetPersonLeavesTable();
            personInfo = new PersonInfo();
            gridCtrl_StudentInfo.DataSource = personInfo.GetPersonInfoTable();
        }
        /// <summary>
        /// Çë¼ÙÊÂ¼þ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTAKINGLEAVE_Click(object sender, EventArgs e)
        {
            LeaveInfo = new LeaveInfo();
            LeaveInfo.nID = textEditID.Text;
            LeaveInfo.tLEAVEDATE = dateTimePickerFROM.Value;
            LeaveInfo.tDUEDATE = dateTimePickerTO.Value;
            LeaveInfo.strReason = radioGroupREASON.Properties.Items[radioGroupREASON.SelectedIndex].Description;
            LeaveInfo.InsertLeaveRecord(LeaveInfo);
            gridControlLEAVES.DataSource = LeaveInfo.GetPersonLeavesTable();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                bFlags = false;
                DataRow dr = LeaveInfo.QueryLeaveInfoDataRow(gridView1.GetFocusedRowCellDisplayText(gridColumn9));
                textBoxNAME.Text = dr[gridColumn2.FieldName].ToString();
                textEditID.Text=dr["ID"].ToString();
                comboBoxGRADE.Text = dr["GRADE"].ToString();
                comboBoxTEAM.Text = dr["TEAM"].ToString();
                richTextBoxMARK.Text = dr["REASON"].ToString();
                
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.RowCount != 0)
            {
                bFlags = false;
                textBoxNAME.Text = gridView2.GetFocusedRowCellDisplayText(gridColumn8);
                textEditID.Text = gridView2.GetFocusedRowCellDisplayText(gridColumn1);
                comboBoxGRADE.Text = gridView2.GetFocusedRowCellDisplayText(gridColumn7);
                comboBoxTEAM.Text = gridView2.GetFocusedRowCellDisplayText(gridColumn14);
            }
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            LeaveInfo.CancelLeaveRecord(textEditID.Text);
            gridControlLEAVES.DataSource = LeaveInfo.GetPersonLeavesTable();
        }

        private void textBoxNAME_TextChanged(object sender, EventArgs e)
        {
            if(bFlags)
               gridCtrl_StudentInfo.DataSource= LeaveInfo.QueryPersonInfoDatatable(textBoxNAME.Text);
        }

        private void textBoxNAME_MouseEnter(object sender, EventArgs e)
        {
            bFlags = true;
        }






    }
}
