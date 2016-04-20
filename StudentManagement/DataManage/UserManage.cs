using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace StudentManagement
{
    /// <summary>
    /// �û�������
    /// </summary>
    public  class UserManage
    {
        /// <summary>
        /// �û�ID
        /// </summary>
        public string UserID;
        /// <summary>
        /// �û�����
        /// </summary>
        public string UserName;
        /// <summary>
        /// �û�����
        /// </summary>
        public string UserPassword;
        /// <summary>
        /// �û�Ȩ��
        /// </summary>
        public string UserRole;
        /// <summary>
        /// ���ݿ�������
        /// </summary>
        private DBConnection db;
        /// <summary>
        /// access����ؼ���
        /// </summary>
        private OleDbConnection oleConn;
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userManage"></param>
        public UserManage(UserManage userManage)
        {
            UserID = userManage.UserID;
            UserName = userManage.UserName;
            UserPassword = userManage.UserPassword;
            UserRole = userManage.UserRole;
        }
        /// <summary>
        /// �������ݿ�
        /// </summary>
        public UserManage()
        {
            db = new DBConnection();
            oleConn = new OleDbConnection();
        }
        /// <summary>
        /// �û���¼
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="PW"></param>
        /// <returns></returns>
        public MatchUser UserLogin(string ID,string PW)
        {
            string strSQL = "select * from UserManage where ID='" + ID + "'";
            DataRow dr = db.ExecuteDataRow(strSQL, oleConn);
            if (dr == null)
                return MatchUser.�û�������;
            else
            {
                if (dr["PASSWORD"].ToString() == PW)
                {
                    UserName = dr["USERNAME"].ToString();
                    UserRole = dr["ROLE"].ToString();
                    return MatchUser.��½�ɹ�;
                }
                else
                    return MatchUser.�������;
            }
        }
        public void InsertUser(UserManage userManage)
        {
        }
        public void DeleteUser(string ID)
        {
        }
        public void ModifyUserInfo(string ID, UserManage userManage)
        {
        }
    }
    public enum MatchUser
    {
        �û�������,
        �������,
        ��½�ɹ�
    }
}
