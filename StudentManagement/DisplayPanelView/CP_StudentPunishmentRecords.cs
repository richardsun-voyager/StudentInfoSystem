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

        #region ��������
        /// <summary>
        /// �Ƿ�ɱ༭
        /// </summary>
        private bool IsEditable;
        /// <summary>
        /// ������
        /// </summary>
        private Punishment punishment;
        /// <summary>
        /// ������Ϣ��
        /// </summary>
        private PersonInfo personInfo;
        /// <summary>
        /// �ж�����Ƿ��ڱ����
        /// </summary>
        private bool IsQuery;
        #endregion

        #region ��Ա������
        /// <summary>
        /// ��ʾѧ����Ϣ
        /// </summary>
        /// <param name="dt"></param>
        private void FillStudentInfoDatatable(DataTable dt)
        {
            gridControlSTUDENTINFO.DataSource = dt; 
            gridView2.ExpandAllGroups();
        }
        /// <summary>
        /// ��ʾ������Ϣ
        /// </summary>
        /// <param name="dt"></param>
        private void FillPunishRecordsDatatable(DataTable dt)
        {
            gridControlPUNISHRECORDS.DataSource = dt;
            gridView1.ExpandAllGroups();
            textEditQUANTITIZE.Text = Statistic("����", gridColumn6).ToString();
            textEditERROR.Text = Statistic("�ǹ�", gridColumn6).ToString();
           textEditWARNING.Text = Statistic("����", gridColumn6).ToString();
           textEditPARTYNUM.Text = Statistic("True", gridColumn4).ToString();
        }
        /// <summary>
        /// ���´�����Ϣ���
        /// </summary>
        private void UpdatePunishDataTable()
        {
            FillPunishRecordsDatatable(punishment.GetPunishmentDataTable());
        }
        /// <summary>
        /// ͳ�ƴ�����Ϣ
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
        /// �жϴ�������
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        private int JudgeTypeIndex(string action)
        {
            int index = -1;
            switch (action)
            {
                case "����":
                    index=0;break;
                case "�ǹ�":
                    index =1;break;
                case "����":
                    index=2;break;
                default:
                    index=3;break;
            }
            return index;
        }
        #endregion

        #region �¼�����
        /// <summary>
        /// �����ʼ��
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
        /// ��Ӽ�¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonADDRECORD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��������ѧԱ?","ȷ��",MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    MessageBox.Show("��������!");
                }
            }
        }
        
        /// <summary>
        /// ��굥������ʱ��ʾ������Ϣ
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
        /// ��굥�����ʱ��ʾ�������
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
                MessageBox.Show("���ݲ���ȷ��");
            }
        }
        /// <summary>
        /// ɾ����¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDELETERECORD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ȡ����ѧԱ��¼?", "ȷ��", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                punishment.DeletePunishRecord(textEditID.Text);
                UpdatePunishDataTable();
            }
        }
        /// <summary>
        /// ��̬��ѯ������Ϣ
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
        /// չ�����б����Ϣ
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
        /// ��ʾ���б����Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSHOWALL_CheckedChanged(object sender, EventArgs e)
        {
            FillStudentInfoDatatable(personInfo.GetPersonInfoTable());
            FillPunishRecordsDatatable(punishment.GetPunishmentDataTable());
        }
        /// <summary>
        /// ��ѯ����Υ�ͼ�¼
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
