using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace StudentManagement
{
    /// <summary>
    /// 用户管理类
    /// </summary>
    public  class UserManage
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID;
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassword;
        /// <summary>
        /// 用户权限
        /// </summary>
        public string UserRole;
        /// <summary>
        /// 数据库联接类
        /// </summary>
        private DBConnection db;
        /// <summary>
        /// access联结关键字
        /// </summary>
        private OleDbConnection oleConn;
        /// <summary>
        /// 构造函数
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
        /// 连接数据库
        /// </summary>
        public UserManage()
        {
            db = new DBConnection();
            oleConn = new OleDbConnection();
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="PW"></param>
        /// <returns></returns>
        public MatchUser UserLogin(string ID,string PW)
        {
            string strSQL = "select * from UserManage where ID='" + ID + "'";
            DataRow dr = db.ExecuteDataRow(strSQL, oleConn);
            if (dr == null)
                return MatchUser.用户不存在;
            else
            {
                if (dr["PASSWORD"].ToString() == PW)
                {
                    UserName = dr["USERNAME"].ToString();
                    UserRole = dr["ROLE"].ToString();
                    return MatchUser.登陆成功;
                }
                else
                    return MatchUser.密码错误;
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
        用户不存在,
        密码错误,
        登陆成功
    }
}
