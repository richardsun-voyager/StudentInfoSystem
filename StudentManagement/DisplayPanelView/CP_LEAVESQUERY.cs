using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CP_LEAVESQUERY : UserControl
    {
        public CP_LEAVESQUERY()
        {
            InitializeComponent();
        }

        #region ��������
        /// <summary>
        /// �����Ϣ����
        /// </summary>
        private LeaveInfo leavInfo;
        /// <summary>
        /// ѧ����Ϣ����
        /// </summary>
        private PersonInfo personInfo;
        #endregion

        #region ��Ա����
        /// <summary>
        /// ���ϲ�ѯ
        /// </summary>
        private void JointQuery()
        {
              try
            {
                if (radioGroupSELECT.SelectedIndex == 0)
                {
                    FillDatagridView(leavInfo.QueryAllPersonLeavesTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text,dateTimePickerFROM.Value,dateTimePickerTO.Value));
                }
                else if (radioGroupSELECT.SelectedIndex == 1)
                {
                    FillDatagridView(personInfo.QueryAwayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
                }
                else if (radioGroupSELECT.SelectedIndex == 2)
                {
                    FillDatagridView(personInfo.QueryStayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
                }
                else if (radioGroupSELECT.SelectedIndex == 3)
                {
                    FillDatagridView(personInfo.QueryOverdatePersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
                    }
            }
            catch
            {
                MessageBox.Show("��ѯ�쳣��");
            }
        }
        /// <summary>
        /// �����
        /// </summary>
        /// <param name="dt"></param>
        private void FillDatagridView(DataTable dt)
        {
            if (dt != null)
            {
                gridControlLEAVEINFO.DataSource = dt;
                gridView1.ExpandAllGroups();
                textBoxCOUNT.Text = dt.Rows.Count.ToString();
                textBoxPARTYCOUNT.Text = Statistic("IsPartyMember", "True", dt).ToString();
            }
            else
                MessageBox.Show("���Դ���ݻ�ȡ�쳣!");
        }
        /// <summary>
        /// ����ͳ��
        /// </summary>
        /// <param name="item"></param>
        /// <param name="values"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private int Statistic(string item,string values,DataTable dt)
        {
            int count =0;
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                DataRow dr = dt.Rows[i];
                if (dr[item].ToString() == values)
                    count++;
            }
            return count;
        }
        #endregion
        /// <summary>
        /// ��ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQUERY_Click(object sender, EventArgs e)
        {
      
                JointQuery();
        
        }
        /// <summary>
        /// �����ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CP_LEAVESQUERY_Load(object sender, EventArgs e)
        {
            leavInfo = new LeaveInfo();
            personInfo = new PersonInfo(); 
            FillDatagridView(leavInfo.GetAllPersonLeavesTable());

        }
        /// <summary>
        /// ѡ��չ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEXPAND_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEXPAND.Checked)
                gridView1.ExpandAllGroups();
            else
                gridView1.CollapseAllGroups();
        }
        /// <summary>
        /// ��״̬�鿴������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioGroupSELECT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (radioGroupSELECT.SelectedIndex == 0)
                //{
                //    FillDatagridView(leavInfo.QueryAllPersonLeavesTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
                //}
                //else if (radioGroupSELECT.SelectedIndex == 1)
                //{
                //    FillDatagridView(personInfo.QueryAwayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
                //}
                //else if (radioGroupSELECT.SelectedIndex == 2)
                //{
                //    FillDatagridView(personInfo.QueryStayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
                //}
                //else if (radioGroupSELECT.SelectedIndex == 3)
                //{
                //    FillDatagridView(personInfo.QueryOverdatePersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
                //}
                JointQuery();
            }
            catch
            {
                MessageBox.Show("��ѯ�쳣��");
            }
        }
        /// <summary>
        /// ���������ʾ��ǰ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
        /// <summary>
        /// ��̬����ģ����ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNAME_TextChanged(object sender, EventArgs e)
        {
            //if (radioGroupSELECT.SelectedIndex == 0)
            //{
            //    FillDatagridView(leavInfo.QueryAllPersonLeavesTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            //else if (radioGroupSELECT.SelectedIndex == 1)
            //{
            //    FillDatagridView(personInfo.QueryAwayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            //else if (radioGroupSELECT.SelectedIndex == 2)
            //{
            //    FillDatagridView(personInfo.QueryStayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            //else if (radioGroupSELECT.SelectedIndex == 3)
            //{
            //    FillDatagridView(personInfo.QueryOverdatePersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            JointQuery();
        }
        /// <summary>
        /// ��̬ѧ��ģ����ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            //if (radioGroupSELECT.SelectedIndex == 0)
            //{
            //    FillDatagridView(leavInfo.QueryAllPersonLeavesTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            //else if (radioGroupSELECT.SelectedIndex == 1)
            //{
            //    FillDatagridView(personInfo.QueryAwayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            //else if (radioGroupSELECT.SelectedIndex == 2)
            //{
            //    FillDatagridView(personInfo.QueryStayPersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            //else if (radioGroupSELECT.SelectedIndex == 3)
            //{
            //    FillDatagridView(personInfo.QueryOverdatePersonInfoTable(comboBoxGRADE.Text, comboBoxTEAM.Text, textBoxNAME.Text, textBoxID.Text));
            //}
            JointQuery();
        }

       


    }
}
