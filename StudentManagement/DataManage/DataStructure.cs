using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace StudentManagement
{
    /// <summary>
    /// 个人信息类
    /// </summary>
    class PersonInfo
    {
        public string nID;
        public string nGrade;
        public string strGender;
        public DateTime tBirthday;
        public string strName;
        public string strAddress;
        public string nTeam;
        public string nClass;
        public bool IsPartyMember;
        public bool IsCadre;
        public string strContact;
        public string strMark;
        public string strPicPath;
        private DBConnection db;
        private OleDbConnection oleConn;
        //public PersonInfo(DBConnection DB, OleDbConnection OleConn)
        //{
        //    db = DB;
        //    oleConn = OleConn;
        //}
        public PersonInfo() 
        {
            db = new DBConnection();
            oleConn = new OleDbConnection();
        }
        public PersonInfo(PersonInfo personInfo)
        {
            nID = personInfo.nID;
            nGrade = personInfo.nGrade;
            strAddress = personInfo.strAddress;
            nClass = personInfo.nClass;
            strName = personInfo.strName;
            nTeam = personInfo.nTeam;
            strContact = personInfo.strContact;
            strMark = personInfo.strMark;
            tBirthday = personInfo.tBirthday;
            IsPartyMember = personInfo.IsPartyMember;
            IsCadre = personInfo.IsCadre;
            strGender = personInfo.strGender;
            strPicPath = personInfo.strPicPath;
        }
        /// <summary>
        /// 插入个人信息
        /// </summary>
        /// <param name="personInfo"></param>
        public void InsertPersonRecord(PersonInfo personInfo)
        {

            string str1 = personInfo.IsPartyMember == true ? "true" : "false";
            string str2 = personInfo.IsCadre == true ? "true" : "false";
            string strSQL = "insert into StudentBasicInfo(ID,GRADE,NAME,CLASS,TEAM,IsPartyMember,IsCadre,GENDER,ADDRESS,BIRTHDAY,CONTACT,MARK,PIC) values('" + personInfo.nID + "','" + personInfo.nGrade + "','" + personInfo.strName + "','" + personInfo.nClass + "','" + personInfo.nTeam + "'," + str1 + "," + str2 + ",'" + personInfo.strGender + "','" + personInfo.strAddress + "',#" + personInfo.tBirthday.ToString() + "#,'" + personInfo.strContact + "','" + personInfo.strMark + "','"+personInfo.strPicPath+"')";
            db.ExecuteNonQuery(strSQL, oleConn);
        }

        /// <summary>
        /// 删除个人信息
        /// </summary>
        /// <param name="nID"></param>
        public void DeletePersonRecord(string nID)
        {
            string strSQL = "delete from StudentBasicInfo where ID='" + nID + "'";
            db.ExecuteNonQuery(strSQL, oleConn);
        }
        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="nID"></param>
        public void ModifyPersonRecord(PersonInfo personInfo, string nID)
        {
            //string strSQL = "update StudentBasicInfo set  ID='" + personInfo.nID + "' GRADE='" + personInfo.nGrade + "' CLASS='" + personInfo.nClass + "' TEAM='" + personInfo.nTeam + "' ";
            ////   strSQL += " where ID='" + nID + "'";
            //db.ExecuteNonQuery(strSQL, oleConn);
            DeletePersonRecord(nID);
            InsertPersonRecord(personInfo);
        }
        /// <summary>
        /// 获取学生表信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetPersonInfoTable()
        {
            return GetDataTable("StudentBasicInfo");
        }
        /// <summary>
        /// 获取在位人员
        /// </summary>
        /// <param name="Grade"></param>
        /// <returns></returns>
        public DataTable GetStayPersonInfoTable(string Grade)
        {
            string strSQL = "select * from StudentBasicInfo where GRADE='" + Grade + "' and ID not in(select ID from StudentLeaveRecords where ISBACK=false)";
            DataSet ds = db.ExecuteDataSet(strSQL, oleConn);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        /// <summary>
        /// 查询在位人员
        /// </summary>
        /// <param name="Grade"></param>
        /// <returns></returns>
        public DataTable QueryStayPersonInfoTable(string Grade,string TEAM,string NAME,string ID)
        {
            string strSQL = "SELECT * from StudentBasicInfo";
            strSQL+=" where StudentBasicInfo.ID not in(select ID from StudentLeaveRecords where ISBACK=false) and StudentBasicInfo.GRADE like'%" + Grade + "%' and StudentBasicInfo.TEAM like '%" + TEAM + "%' and StudentBasicInfo.NAME like '%"+NAME+"%'";
            strSQL += " and StudentBasicInfo.ID like '" + ID + "%'";
            DataSet ds = db.ExecuteDataSet(strSQL, oleConn);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        /// <summary>
        /// 获取已请假人员信息
        /// </summary>
        /// <param name="Grade"></param>
        /// <returns></returns>
        public DataTable GetAwayPersonInfoTable(string Grade)
        {
            //string strSQL = "select * from StudentBasicInfo where GRADE='" + Grade + "' and ID in(select ID from StudentLeaveRecords where ISBACK=false)";
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.GRADE,StudentBasicInfo.TEAM,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.ISBACK,StudentLeaveRecords.RETURNDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID";
            strSQL += " where StudentLeaveRecords.ISBACK=false and StudentBasicInfo.GRADE ='"+Grade+"'";
            DataSet ds = db.ExecuteDataSet(strSQL, oleConn);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public DataTable QueryAwayPersonInfoTable(string Grade, string TEAM, string NAME,string ID)
        {
            //string strSQL = "select * from StudentBasicInfo where GRADE='" + Grade + "' and ID in(select ID from StudentLeaveRecords where ISBACK=false)";
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.GRADE,StudentBasicInfo.TEAM,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.ISBACK,StudentLeaveRecords.RETURNDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID";
            strSQL += " where StudentLeaveRecords.ISBACK=false and StudentBasicInfo.GRADE like'%" + Grade + "%' and StudentBasicInfo.TEAM like '%" + TEAM + "%' and StudentBasicInfo.NAME like '%" + NAME + "%'";
            strSQL += " and StudentBasicInfo.ID like '" + ID + "%'";
            DataSet ds = db.ExecuteDataSet(strSQL, oleConn);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        /// <summary>
        /// 获取超假人员信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetOverdatePersonInfoTable()
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.GRADE,StudentBasicInfo.TEAM,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.ISBACK,StudentLeaveRecords.RETURNDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID";
            strSQL+=" where StudentLeaveRecords.ISBACK=false and StudentLeaveRecords.DUEDATE<#"+DateTime.Today+"#";
            DataSet ds = db.ExecuteDataSet(strSQL, oleConn);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public DataTable QueryOverdatePersonInfoTable(string Grade, string TEAM, string NAME,string ID)
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.GRADE,StudentBasicInfo.TEAM,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.ISBACK,StudentLeaveRecords.RETURNDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID";
            strSQL += " where StudentLeaveRecords.ISBACK=false and StudentLeaveRecords.DUEDATE<#" + DateTime.Today + "#" + " and StudentBasicInfo.GRADE like'%" + Grade + "%' and StudentBasicInfo.TEAM like '%" + TEAM + "%' and StudentBasicInfo.NAME like '%" + NAME + "%'";
            strSQL += " and StudentBasicInfo.ID like '" + ID + "%'";
            DataSet ds = db.ExecuteDataSet(strSQL, oleConn);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        /// <summary>
        /// 或取学生列信息
        /// </summary>
        /// <param name="rowHandle"></param>
        /// <returns></returns>
        public DataRow GetPersonInfoDataRow(string strID)
        {
            if (strID != "")
            {
                string strSQL = "select * from StudentBasicInfo where ID='" + strID + "'";
                DataSet ds = db.ExecuteDataSet(strSQL, oleConn);
                DataTable dt = ds.Tables[0];
                DataRow dr = dt.Rows[0];
                return dr;
            }
            else
                return null;
        }
        /// <summary>
        /// 或取学生列信息
        /// </summary>
        /// <param name="rowHandle"></param>
        /// <returns></returns>
        public DataRow GetPersonInfoDataRow(int rowHandle)
        {
            DataTable dataTable = GetDataTable("StudentBasicInfo");
            DataRow dataRow = dataTable.Rows[rowHandle];
            return dataRow;
        }
      
        /// <summary>
        /// 获取查询后学生表,模糊查询
        /// </summary>
        /// <param name="strPara"></param>
        /// <returns></returns>
        public DataSet QueryPersonInfoDataset(string strName)
        {
            string strSQL = "select * from StudentBasicInfo where ( NAME like '%" + strName + "%'";
            strSQL += " or ID like '%" + strName + "%'";
            strSQL += " or GRADE like '%" + strName + "%'";
            strSQL += " or CLASS like '%" + strName + "%'";
            strSQL += " or ADDRESS like '%" + strName + "%'";
            strSQL += " or TEAM like '%" + strName + "%'";
            strSQL += " or GENDER like '%" + strName + "%')";
            //if (strName == "True")
            //{
            //    strSQL += " or IsPartyMember = true ";
            //    strSQL += " or IsCadre  = true)";
            //}
            //else if (strName == "False")
            //{
            //    strSQL += " or IsPartyMember = true ";
            //    strSQL += " or IsCadre  = true)";
            //}
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        /// <summary>
        /// 查询bool类型数据集，模糊查询
        /// </summary>
        /// <param name="IsChecked"></param>
        /// <returns></returns>
        public DataSet QueryPersonInfodataset(string Column,bool IsChecked)
        {
            string strSQL = "select * from StudentBasicInfo where ";
            strSQL += Column+" =" + IsChecked ;
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        public DataTable QueryPersonInfodatatable(string Column, bool IsChecked)
        {
            return QueryPersonInfodataset(Column, IsChecked).Tables[0];
        }
        /// <summary>
        /// 查询个人信息
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        public DataSet QueryPersonInfoDataset(PersonInfo personInfo)
        {
            string strSQL = "select * from StudentBasicInfo where ( NAME like '%" + personInfo.strName + "%'";
            strSQL += " and ID like '%" + personInfo.nID + "%'";
            strSQL += " and GRADE like '%" + personInfo.nGrade + "%'";
            strSQL += " and CLASS like '%" + personInfo.nGrade + "%'";
            strSQL += " and ADDRESS like '%" + personInfo.strAddress + "%'";
            strSQL += " and TEAM like '%" + personInfo.nTeam + "%'";
            strSQL += " and GENDER like '%" + personInfo.strGender + "%')";
            strSQL += " and IsPartyMember =" + strName + ")";
            strSQL += " and IsCadre like =" + strName + ")";
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        /// <summary>
        /// 返回查询数据表,模糊匹配
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public DataTable QueryPersonInfoDatatable(string strName)
        {
            return QueryPersonInfoDataset(strName).Tables[0];
        }
        /// <summary>
        /// 全文查询
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        public DataTable QueryPersonInfoDatatable(PersonInfo personInfo)
        {
            return QueryPersonInfoDataset(personInfo).Tables[0];
        }
        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string TableName)
        {
            string strSQL = "select * from " + TableName+" order by ID";
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        /// <summary>
        /// 返回数据表
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string TableName)
        {
            return GetDataSet(TableName).Tables[0];
        }
    }
     /// <summary>
     /// 请假类
     /// </summary>
    class LeaveInfo
    {
        public string nID;
        public DateTime tLEAVEDATE;
        public DateTime tDUEDATE;
        public DateTime tRETURNDATE;
        public bool ISBACK;
        public bool ISOVERDATE;
        public string strReason;
        private DBConnection db;
        private OleDbConnection oleConn;
        public LeaveInfo()
        {
            db = new DBConnection();
            oleConn = new OleDbConnection();
        }
        public LeaveInfo(LeaveInfo leaveinfo)
        {
            nID = leaveinfo.nID;
            tDUEDATE = leaveinfo.tDUEDATE;
            tLEAVEDATE = leaveinfo.tLEAVEDATE;
            tRETURNDATE = leaveinfo.tRETURNDATE;
            strReason = leaveinfo.strReason;
            ISBACK = leaveinfo.ISBACK;
            ISOVERDATE = leaveinfo.ISOVERDATE;
        }
        /// <summary>
        /// 获取已离开学生请假表
        /// </summary>
        /// <returns></returns>
        public DataTable GetPersonLeavesTable()
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.TEAM,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.ISBACK,StudentLeaveRecords.RETURNDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID where StudentLeaveRecords.ISBACK=false order by StudentLeaveRecords.LEAVEDATE";
            return db.ExecuteDataSet(strSQL, oleConn).Tables[0];
        }       
        /// <summary>
        /// 获取所有学生请假表
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllPersonLeavesTable()
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.TEAM,StudentBasicInfo.GRADE,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.ISBACK,StudentLeaveRecords.RETURNDATE,StudentLeaveRecords.REASON,StudentLeaveRecords.ISOVERDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID order by StudentLeaveRecords.ID";
            return db.ExecuteDataSet(strSQL, oleConn).Tables[0];
        }
        public DataTable QueryAllPersonLeavesTable(string Grade, string TEAM, string NAME,string ID,DateTime t1,DateTime t2)
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.TEAM,StudentBasicInfo.GRADE,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.ISBACK,StudentLeaveRecords.RETURNDATE,StudentLeaveRecords.REASON,StudentLeaveRecords.ISOVERDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID ";
            strSQL += " where StudentBasicInfo.ID like '"+ID+"%' and StudentBasicInfo.GRADE like'%" + Grade + "%' and StudentBasicInfo.TEAM like '%" + TEAM + "%' and StudentBasicInfo.NAME like '%" + NAME + "%' ";
            strSQL += " and StudentLeaveRecords.LEAVEDATE>=#"+t1+"# and StudentLeaveRecords.DUEDATE <=#"+t2+"#";
            strSQL += "order by StudentLeaveRecords.ID";
            return db.ExecuteDataSet(strSQL, oleConn).Tables[0];
        }
        /// <summary>
        /// 插入请假信息
        /// </summary>
        /// <param name="leaveInfo"></param>
        public void InsertLeaveRecord(LeaveInfo leaveInfo)
        {
            string str = "select ID from StudentLeaveRecords where StudentLeaveRecords.ID= '" + leaveInfo.nID + "' and StudentLeaveRecords.ISBACK=false";
            DataTable dt= db.ExecuteDataTable(str, oleConn);
            if (dt.Rows.Count == 0)
            {
                string str1 = "false";
                string strSQL = "insert into StudentLeaveRecords(ID,LEAVEDATE,DUEDATE,ISBACK,REASON) values('" + leaveInfo.nID + "',#" + leaveInfo.tLEAVEDATE + "#,#" + leaveInfo.tDUEDATE + "#," + str1 + ",'" + leaveInfo.strReason + "')";
                db.ExecuteNonQuery(strSQL, oleConn);
            }
            else
            {
                MessageBox.Show("该学员未销假");
            }
        }
        /// <summary>
        /// 返回选中行
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataRow QueryLeaveInfoDataRow(string ID)
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.TEAM,StudentBasicInfo.GRADE,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentBasicInfo.IsPartyMember,StudentBasicInfo.IsCadre,StudentLeaveRecords.REASON,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.RETURNDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID where " + "StudentBasicInfo.ID='" + ID + "'"; ;
            DataTable dt= db.ExecuteDataTable(strSQL, oleConn);
            DataRow dr=null;
            if (dt.Rows.Count != 0)
            {
                dr = dt.Rows[0];

            }
            else
                MessageBox.Show("数据异常");
            return dr;
        }
        /// <summary>
        /// 销假记录
        /// </summary>
        /// <param name="nID"></param>
        public void CancelLeaveRecord(string nID)
        {
            string strSQL = "update StudentLeaveRecords set RETURNDATE=#"+DateTime.Today+"# where ISBACK=false and ID='" + nID + "'" ;
            db.ExecuteNonQuery(strSQL,oleConn);
            strSQL = "select * from StudentLeaveRecords where  RETURNDATE>DUEDATE and ISBACK=false and ID='" + nID + "'";
            if (db.ExecuteDataTable(strSQL, oleConn).Rows.Count!=0)
            {
                strSQL = "update StudentLeaveRecords set ISOVERDATE=true where RETURNDATE>DUEDATE and ISBACK=false  and ID='" + nID + "'";
                db.ExecuteNonQuery(strSQL, oleConn);
                MessageBox.Show("该学员超假");
            }
            strSQL = "update StudentLeaveRecords set ISBACK=true where ISBACK=false and ID='" + nID + "'" ;
            db.ExecuteNonQuery(strSQL,oleConn);

            
               
        }
        /// <summary>
        /// 查询个人信息
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        public DataSet QueryPersonInfoDataset(string nID)
        {
            string strSQL = "select * from StudentBasicInfo where  NAME like '%" + nID + "%'";
           
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        /// <summary>
        /// 查询个人信息
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        public DataTable QueryPersonInfoDatatable(string nID)
        {
            return QueryPersonInfoDataset(nID).Tables[0];
        }
    }
    /// <summary>
    /// 处罚类
    /// </summary>
    class Punishment
    {
        public string nID;
        public string AuthorizeUnit;//批准单位
        public DateTime ExeDateTime;//批准时间
        public string Punishement;//处罚方式
        public string Reason;//处罚理由
        private DBConnection db;//数据库联接类
        private OleDbConnection oleConn;//联接关键字
        /// <summary>
        /// 批准单位
        /// </summary>
        public enum UnitType
        {
            学员队,
            大队,
            院
        }
        /// <summary>
        /// 处罚方式
        /// </summary>
        public enum PunishmentType
        {
            量化,
            警告,
            记过
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public Punishment()
        {
            db = new DBConnection();
            oleConn = new OleDbConnection();
        }
        /// <summary>
        /// 返回内连接数据表
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.NAME,StudentBasicInfo.GRADE,StudentBasicInfo.TEAM,StudentBasicInfo.IsPartyMember,StudentPunishmentRecords.PUNISHMENT,StudentPunishmentRecords.EXEDATETIME, StudentPunishmentRecords.EXEUNIT,StudentPunishmentRecords.REASON ";
            strSQL+=" FROM StudentBasicInfo INNER JOIN StudentPunishmentRecords ON StudentBasicInfo.ID = StudentPunishmentRecords.ID";
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        /// <summary>
        /// 返回学生处罚信息表
        /// </summary>
        /// <returns></returns>
        public DataTable GetPunishmentDataTable()
        {
            return GetDataSet().Tables[0];
        }
        /// <summary>
        /// 添加处罚记录
        /// </summary>
        /// <param name="punishment"></param>
        public void InsertPunishRecord(Punishment punishment)
        {
            string strSQL = " insert into StudentPunishmentRecords(ID,EXEDATETIME,EXEUNIT,PUNISHMENT,REASON) values(";
            strSQL += "'" + punishment.nID + "',#" + punishment.ExeDateTime + "#,'" + punishment.AuthorizeUnit.ToString() + "','"+punishment.Punishement.ToString()+"','" + punishment.Reason + "')";
            db.ExecuteNonQuery(strSQL, oleConn);
        }
        /// <summary>
        /// 删除处罚记录
        /// </summary>
        /// <param name="nID"></param>
        public void DeletePunishRecord(string nID)
        {
            string strSQL = "delete from StudentPunishmentRecords where ID='" + nID + "'";
            db.ExecuteNonQuery(strSQL, oleConn);
        }
        /// <summary>
        /// 修改处罚信息
        /// </summary>
        /// <param name="nID"></param>
        /// <param name="punishment"></param>
        public void ModifyPunishRecord(string nID, Punishment punishment)
        {
            string strSQL = "update StudentPunishmentRecords set ID='" + punishment.nID + "',EXEDATETIME=#"+punishment.ExeDateTime+"#,EXEUNIT='"+punishment.AuthorizeUnit.ToString()+"',PUNISHMENT='"+punishment.Punishement.ToString()+"',REASON='"+punishment.Reason+"'";
            strSQL += " where ID='" + nID + "'";
            db.ExecuteNonQuery(strSQL, oleConn);
        }
        /// <summary>
        /// 返回查询的结果集
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet QueryPunishRecordDataset(string name)
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.NAME,StudentBasicInfo.GRADE,StudentBasicInfo.TEAM,StudentBasicInfo.IsPartyMember,StudentPunishmentRecords.PUNISHMENT,StudentPunishmentRecords.EXEDATETIME, StudentPunishmentRecords.EXEUNIT,StudentPunishmentRecords.REASON ";
            strSQL += " FROM StudentBasicInfo INNER JOIN StudentPunishmentRecords ON StudentBasicInfo.ID = StudentPunishmentRecords.ID";
            strSQL += " where StudentBasicInfo.NAME like '%"+name+"%'";
            strSQL += " or StudentBasicInfo.ID like '%" + name + "%'";
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        /// <summary>
        /// 返回查询的结果表格
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable QueryPunishRecordDataTable(string name)
        {
            return QueryPunishRecordDataset(name).Tables[0];
        }
    }
}
