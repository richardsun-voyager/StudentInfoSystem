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
    public partial class CP_PersonInfo : UserControl
    {
        public CP_PersonInfo(bool isEditable)
        {
            IsEditable = isEditable;
            InitializeComponent();
        }
        private static PersonInfo personInfo;
        private DBConnection db = new DBConnection();
        private OleDbConnection oleConn = new OleDbConnection();
        private bool IsEditable;
        private bool IsQuery=false;
        private string text;
        private void CP_PersonInfo_Load(object sender, EventArgs e)
        {
            if (!IsEditable)//不可编辑
            {
                groupBoxEdit.Visible = false;
            }
            else
            {
                groupBoxEdit.Visible = true;
            }
            //连接数据库
            personInfo = new PersonInfo();
            gridCtrl_StudentInfo.DataSource = personInfo.GetPersonInfoTable();

        }
        /// <summary>
        /// 插入个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEditID.Text != "")
                {
                    personInfo = new PersonInfo();
                    personInfo.nID = textEditID.Text;
                    personInfo.strName = textEditNAME.Text;
                    personInfo.nGrade = comboBoxEditGRADE.Text;
                    //comboBoxEditTEAM.SelectedIndex++;
                    personInfo.nTeam = comboBoxEditTEAM.Text;
                    personInfo.nClass = comboBoxEditCLASS.Text;
                    personInfo.strAddress = textEditADDRESS.Text;
                    personInfo.tBirthday = dateTimePickerBIRTHDAY.Value;
                    personInfo.strGender = radioGroupGENDER.Properties.Items[radioGroupGENDER.SelectedIndex].Description;
                    personInfo.IsPartyMember = checkBoxPartyMember.Checked;
                    personInfo.IsCadre = checkBoxCadre.Checked;
                    personInfo.strMark = richTextBoxMARK.Text;
                    personInfo.strContact = textEditPHONE.Text;
                    personInfo.strPicPath = textEditPICPATH.Text;
                    personInfo.InsertPersonRecord(personInfo);
                    gridCtrl_StudentInfo.DataSource = personInfo.GetPersonInfoTable();
                }
                else
                {
                    MessageBox.Show("学号有误");
                }
            }
            catch
            {
                MessageBox.Show("输入有误");
            }
        }

        private void textEditNAME_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //personInfo = new PersonInfo();
                //personInfo.nID = textEditID.Text;

                //personInfo.strName = textEditNAME.Text;
                //personInfo.nGrade = comboBoxEditGRADE.Text;
                //personInfo.nTeam = comboBoxEditTEAM.Text;
                //personInfo.nClass = comboBoxEditCLASS.Text;


                //personInfo.strAddress = textEditADDRESS.Text;
                //personInfo.tBirthday = dateTimePickerBIRTHDAY.Value;
                //personInfo.strGender = radioGroupGENDER.Properties.Items[radioGroupGENDER.SelectedIndex].Description;
                //personInfo.IsPartyMember = checkBoxPartyMember.Checked;
                //personInfo.IsCadre = checkBoxCadre.Checked;

                //gridCtrl_StudentInfo.DataSource = dataManage.QueryPersonInfoDatatable(textEditNAME.Text);
                if (IsQuery)
                {
                    if (!IsEditable)//不可编辑
                        gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfoDatatable(textEditNAME.Text);
                }
            }
            catch
            {
                MessageBox.Show("输入有误");
            }
        }
        private int JudgeEmpty(string str)
        {
            if (str == "")
                return -1;
            else
                return int.Parse(str);
        }

        private void textEditADDRESS_EditValueChanged(object sender, EventArgs e)
        {
            if(IsQuery)
            if (!IsEditable)//不可编辑
                gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfoDatatable(textEditADDRESS.Text);
        }

        private void textEditID_EditValueChanged(object sender, EventArgs e)
        {
            if (IsQuery)
            if (!IsEditable)//不可编辑
                gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfoDatatable(textEditID.Text);
        }

    

        private void radioGroupGENDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsQuery)
                if (!IsEditable)//不可编辑
                {
                    DataTable dt=personInfo.QueryPersonInfoDatatable(radioGroupGENDER.Properties.Items[radioGroupGENDER.SelectedIndex].Description);
                    gridCtrl_StudentInfo.DataSource = dt;
                }
        }

        private void comboBoxEditGRADE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsQuery)
            if (!IsEditable)//不可编辑
            gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfoDatatable(comboBoxEditGRADE.Text);
        }

        private void comboBoxEditTEAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsQuery)
            if (!IsEditable)//不可编辑
            {
                if (comboBoxEditTEAM.SelectedIndex == 0)
                    gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfoDatatable("");
                else
                    gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfoDatatable(comboBoxEditTEAM.Text);
            }
        }

        private void comboBoxEditCLASS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsQuery)
            if (!IsEditable)//不可编辑
                gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfoDatatable(comboBoxEditCLASS.Text);
        }

        private void checkBoxPartyMember_CheckedChanged(object sender, EventArgs e)
        {
            if (IsQuery)
                if (!IsEditable)//不可编辑
                    gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfodatatable("IsPartyMember", checkBoxPartyMember.Checked);
        }

        private void checkBoxCadre_CheckedChanged(object sender, EventArgs e)
        {
            if (IsQuery)
                if (!IsEditable)//不可编辑
                    gridCtrl_StudentInfo.DataSource = personInfo.QueryPersonInfodatatable("IsCadre", checkBoxCadre.Checked);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IsQuery = false;
            text=gridView1.GetFocusedRowCellDisplayText(gridColumn1);
            textEditID.Text = text;
            textEditADDRESS.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn9);
            textEditNAME.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn2);
            comboBoxEditCLASS.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn3);
            comboBoxEditGRADE.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn7);
            comboBoxEditTEAM.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn4);
            checkBoxCadre.Checked = gridView1.GetFocusedRowCellDisplayText(gridColumn6)=="true"?true:false;
            checkBoxPartyMember.Checked = gridView1.GetFocusedRowCellDisplayText(gridColumn5) == "true" ? true : false;
            if (gridView1.GetFocusedRowCellDisplayText(gridColumn8).ToString() == "男")
                radioGroupGENDER.SelectedIndex = 0;
            else
                radioGroupGENDER.SelectedIndex = 1;
            DataRow dr = personInfo.GetPersonInfoDataRow(text);
            if(dr!=null)
                pictureBox.ImageLocation = dr["PIC"].ToString();
            buttonDEL.Enabled = true;
            
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除?", "删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                personInfo.DeletePersonRecord(text);
                gridCtrl_StudentInfo.DataSource = personInfo.GetPersonInfoTable();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            //personInfo = new PersonInfo();
            personInfo.nID = textEditID.Text;

            personInfo.strName = textEditNAME.Text;
            personInfo.nGrade = comboBoxEditGRADE.Text;
            personInfo.nTeam = comboBoxEditTEAM.Text;
            personInfo.nClass = comboBoxEditCLASS.Text;


            personInfo.strAddress = textEditADDRESS.Text;
            personInfo.tBirthday = dateTimePickerBIRTHDAY.Value;
            personInfo.strGender = radioGroupGENDER.Properties.Items[radioGroupGENDER.SelectedIndex].Description;
            personInfo.IsPartyMember = checkBoxPartyMember.Checked;
            personInfo.IsCadre = checkBoxCadre.Checked;
            personInfo.ModifyPersonRecord(personInfo, text);
            gridCtrl_StudentInfo.DataSource = personInfo.GetPersonInfoTable();
        }

        private void checkBoxCLEAR_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsEditable&&checkBoxCLEAR.Checked)//不可编辑
            {
                textEditID.Text = "";
                textEditNAME.Text = "";
                comboBoxEditGRADE.Text = "";
                comboBoxEditTEAM.Text = "";
                comboBoxEditCLASS.Text = "";
                textEditADDRESS.Text = "";
            }
        }

        private void buttonSELECTPIC_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "选择照片路径";
            dlg.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            dlg.RestoreDirectory = true;//要恢复原路径
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textEditPICPATH.Text = dlg.FileName.Trim();
                pictureBox.ImageLocation = dlg.FileName;
               
               
            }
           
        }

        private void textEditID_MouseEnter(object sender, EventArgs e)
        {
            IsQuery = true;
        }

        private void checkBoxSHOWALL_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSHOWALL.Checked)
                gridCtrl_StudentInfo.DataSource = personInfo.GetPersonInfoTable();
        }






    }
}
