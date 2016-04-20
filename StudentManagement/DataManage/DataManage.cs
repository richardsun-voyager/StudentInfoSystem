using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace StudentManagement
{
    class DataManage
    {
        private DBConnection db;
        private OleDbConnection oleConn;
        public DataManage(DBConnection dbcon,OleDbConnection oleconn)
        {
            db = dbcon;
            oleConn = oleconn;
        }
        /// <summary>
        /// 插入个人信息
        /// </summary>
        /// <param name="personInfo"></param>
        public void InsertPersonRecord(PersonInfo personInfo)
        {

            string str1 = personInfo.IsPartyMember == true ? "true" : "false";
            string str2 = personInfo.IsCadre == true ? "true" : "false";
            string strSQL = "insert into StudentBasicInfo(ID,GRADE,NAME,CLASS,TEAM,IsPartyMember,IsCadre,GENDER,ADDRESS,BIRTHDAY,CONTACT,MARK) values('" + personInfo.nID + "','"+personInfo.nGrade+"','" + personInfo.strName + "','" + personInfo.nClass + "','" + personInfo.nTeam + "'," + str1 + "," + str2 +",'"+personInfo.strGender+"','"+personInfo.strAddress+ "',#"+personInfo.tBirthday.ToString()+"#,'"+personInfo.strContact+"','"+personInfo.strMark+"')";
            db.ExecuteNonQuery(strSQL, oleConn);
        }
        public void InsertPersonLeaveRecord()
        {
        }
        /// <summary>
        /// 删除个人信息
        /// </summary>
        /// <param name="nID"></param>
        public void DeletePersonRecord(string nID)
        {
            string strSQL = "delete from StudentBasicInfo where ID='" + nID+"'";
            db.ExecuteNonQuery(strSQL, oleConn);
        }
        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="nID"></param>
        public void ModifyPersonRecord(PersonInfo personInfo,string nID)
        {
            //string strSQL = "update StudentBasicInfo set  ID='"+personInfo.nID+"' GRADE='"+personInfo.nGrade+"' CLASS='"+personInfo.nClass+"' TEAM
            //   strSQL += " where ID='" + nID + "'";
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
        /// 获取学生请假表
        /// </summary>
        /// <returns></returns>
        public DataTable GetPersonLeavesTable()
        {
            string strSQL = "SELECT StudentBasicInfo.ID,StudentBasicInfo.TEAM,StudentBasicInfo.CLASS,StudentBasicInfo.NAME,StudentLeaveRecords.LEAVEDATE,StudentLeaveRecords.DUEDATE,StudentLeaveRecords.RETURNDATE FROM StudentBasicInfo INNER JOIN StudentLeaveRecords ON StudentBasicInfo.ID = StudentLeaveRecords.ID";
            return db.ExecuteDataSet(strSQL, oleConn).Tables[0];
        }
        /// <summary>
        /// 获取查询后学生表
        /// </summary>
        /// <param name="strPara"></param>
        /// <returns></returns>
        public DataSet QueryPersonInfoDataset(string strName)
        {
            string strSQL = "select * from StudentBasicInfo where ( NAME like '%" + strName+ "%'";
            strSQL += " or ID like '%" + strName + "%'";
            strSQL += " or GRADE like '%" + strName + "%'";
            strSQL += " or CLASS like '%" + strName + "%'";
            strSQL += " or ADDRESS like '%" + strName + "%'";
            strSQL += " or TEAM like '%" + strName + "%'";
            strSQL += " or GENDER like '%" + strName + "%')";
            //strSQL += " or IsPartyMember like '%" + strName + "%')";
            //strSQL += " or IsCadre like '%" + strName + "%')";
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        public DataSet QueryPersonInfoDataset(PersonInfo personInfo)
        {
            string strSQL = "select * from StudentBasicInfo where ( NAME like '%" + personInfo.strName + "%'";
            strSQL += " and ID like '%" + personInfo.nID + "%'";
            strSQL += " and GRADE like '%" + personInfo.nGrade + "%'";
            strSQL += " and CLASS like '%" + personInfo.nGrade + "%'";
            strSQL += " and ADDRESS like '%" + personInfo.strAddress + "%'";
            strSQL += " and TEAM like '%" + personInfo.nTeam + "%'";
            strSQL += " and GENDER like '%" + personInfo.strGender + "%')";
            //strSQL += " or IsPartyMember like '%" + strName + "%')";
            //strSQL += " or IsCadre like '%" + strName + "%')";
            return db.ExecuteDataSet(strSQL, oleConn);
        }
        /// <summary>
        /// 返回查询数据表
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public DataTable QueryPersonInfoDatatable(string strName)
        {
            return QueryPersonInfoDataset(strName).Tables[0];
        }
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
            string strSQL="select * from "+TableName;
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
}
