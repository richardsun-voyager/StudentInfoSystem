using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace StudentManagement
{
    public partial class frmPersonInfo : Form
    {
        public frmPersonInfo()
        {
            InitializeComponent();
        }


        private PersonInfo_S personInfo;
        private DBConnection db = new DBConnection();
        private OleDbConnection oleConn = new OleDbConnection();
        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                personInfo = new PersonInfo_S();

                personInfo.nID = int.Parse(textEditID.Text);
                personInfo.strName = textEditNAME.Text;
                personInfo.nTeam = comboBoxEditTEAM.SelectedIndex + 1;
                personInfo.nClass = int.Parse(comboBoxEditCLASS.Text);
                personInfo.IsPartyMember = checkBoxPartyMember.Checked;
                personInfo.IsCadre = checkBoxCadre.Checked;

                DataManage dm = new DataManage(db, oleConn);
                dm.InsertRecord(personInfo);
                buttonSave.Enabled = false;
                gridCtrl_StudentInfo.DataSource = db.GetStudentBasicInfo(oleConn).Tables[0];

            }
            catch
            {
                MessageBox.Show("输入不正确");
            }
            textEditID.Text = "";
            textEditNAME.Text = "";
            
        }



        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.StudentBasicInfo”中。您可以根据需要移动或移除它。
            db.AccessConn(ref oleConn);
            gridCtrl_StudentInfo.DataSource= db.GetStudentBasicInfo(oleConn).Tables[0];
            db.AccessDisConn(ref oleConn);
            comboBoxEditCLASS.Properties.Items.Clear();
            comboBoxEditCLASS.Properties.Items.Add(1);
            comboBoxEditCLASS.Properties.Items.Add(2);
            comboBoxEditCLASS.Properties.Items.Add(3);
            comboBoxEditCLASS.Properties.Items.Add(4);
            comboBoxEditCLASS.SelectedIndex = 0;
            gridView1.OptionsBehavior.Editable = false;
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBoxEditTEAM_SelectedIndex(object sender, EventArgs e)
        {
            if (comboBoxEditTEAM.SelectedIndex == 0)
            {
                comboBoxEditCLASS.Properties.Items.Clear();
                comboBoxEditCLASS.Properties.Items.Add(1);
                comboBoxEditCLASS.Properties.Items.Add(2);
                comboBoxEditCLASS.Properties.Items.Add(3);
                comboBoxEditCLASS.Properties.Items.Add(4);
            }
            else if (comboBoxEditTEAM.SelectedIndex==1)
            {
                comboBoxEditCLASS.Properties.Items.Clear();
                comboBoxEditCLASS.Properties.Items.Add(5);
                comboBoxEditCLASS.Properties.Items.Add(6);
                comboBoxEditCLASS.Properties.Items.Add(7);
                comboBoxEditCLASS.Properties.Items.Add(8);
            }
            else if (comboBoxEditTEAM.SelectedIndex == 2)
            {
                comboBoxEditCLASS.Properties.Items.Clear();
                comboBoxEditCLASS.Properties.Items.Add(9);
                comboBoxEditCLASS.Properties.Items.Add(10);
                comboBoxEditCLASS.Properties.Items.Add(11);
            }
            else if (comboBoxEditTEAM.SelectedIndex == 3)
            {
                comboBoxEditCLASS.Properties.Items.Clear();
                comboBoxEditCLASS.Properties.Items.Add(12);
                comboBoxEditCLASS.Properties.Items.Add(13);
                comboBoxEditCLASS.Properties.Items.Add(15);
                comboBoxEditCLASS.Properties.Items.Add(16);
            }
            //else if (comboBoxEditTEAM.SelectedIndex == 4)
            //{
            //    comboBoxEditCLASS.Properties.Items.Clear();
            //    comboBoxEditCLASS.Properties.Items.Add(1);
            //    comboBoxEditCLASS.Properties.Items.Add(2);
            //    comboBoxEditCLASS.Properties.Items.Add(3);
            //    comboBoxEditCLASS.Properties.Items.Add(4);
            //}
            //else if (comboBoxEditTEAM.SelectedIndex == 5)
            //{
            //    comboBoxEditCLASS.Properties.Items.Clear();
            //    comboBoxEditCLASS.Properties.Items.Add(1);
            //    comboBoxEditCLASS.Properties.Items.Add(2);
            //    comboBoxEditCLASS.Properties.Items.Add(3);
            //    comboBoxEditCLASS.Properties.Items.Add(4);
            //}
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            textEditID.Text = "";
            textEditNAME.Text = "";
            gridView1.OptionsBehavior.Editable = false;
        }

        private void buttonQUERY_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEditID.Text != "")
                {
                    string strSQL = "select * from StudentBasicInfo where ID=" + textEditID.Text;
                    gridCtrl_StudentInfo.DataSource = db.ExecuteDataSet(strSQL, oleConn).Tables[0].DefaultView;
                }
                else if (textEditNAME.Text != "")
                {
                    string strSQL = "select * from StudentBasicInfo where NAME='" + textEditNAME.Text + "'";
                    gridCtrl_StudentInfo.DataSource = db.ExecuteDataSet(strSQL, oleConn).Tables[0].DefaultView;
                }
                else if (comboBoxEditTEAM.Text != "")
                {
                    int ntemp=comboBoxEditTEAM.SelectedIndex+1;
                    string strSQL = "select * from StudentBasicInfo where TEAM=" + ntemp.ToString();
                    gridCtrl_StudentInfo.DataSource = db.ExecuteDataSet(strSQL, oleConn).Tables[0].DefaultView;
                }
                else if (comboBoxEditCLASS.Text != "")
                {
                    string strSQL = "select * from StudentBasicInfo where CLASS=" + comboBoxEditCLASS.Text;
                    gridCtrl_StudentInfo.DataSource = db.ExecuteDataSet(strSQL, oleConn).Tables[0].DefaultView;
                }
            }
            catch
            { MessageBox.Show("查询有误"); }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
            buttonSave.Enabled = true;
        }
    }
}