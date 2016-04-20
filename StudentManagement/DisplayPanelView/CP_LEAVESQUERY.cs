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

        #region 变量声明
        /// <summary>
        /// 请假信息对象
        /// </summary>
        private LeaveInfo leavInfo;
        /// <summary>
        /// 学生信息对象
        /// </summary>
        private PersonInfo personInfo;
        #endregion

        #region 成员函数
        /// <summary>
        /// 联合查询
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
                MessageBox.Show("查询异常！");
            }
        }
        /// <summary>
        /// 填充表格
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
                MessageBox.Show("表格源数据获取异常!");
        }
        /// <summary>
        /// 数据统计
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
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQUERY_Click(object sender, EventArgs e)
        {
      
                JointQuery();
        
        }
        /// <summary>
        /// 界面初始化
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
        /// 选择展开与否
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
        /// 分状态查看请假情况
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
                MessageBox.Show("查询异常！");
            }
        }
        /// <summary>
        /// 单击表格显示当前信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
        /// <summary>
        /// 动态姓名模糊查询
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
        /// 动态学号模糊查询
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
