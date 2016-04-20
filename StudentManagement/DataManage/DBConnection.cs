using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace StudentManagement
{
    /// <summary>
    /// 数据库连接
    /// </summary>
    class DBConnection
    {
        //连接字符串
        private string ConStr="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\Data\\Student.mdb;Persist Security Info=True;Jet OLEDB:Database Password=xbsun";
        //连接数据库
        public void AccessConn(ref OleDbConnection oleConn)
        {
            try
            {
                oleConn = new OleDbConnection(ConStr);
                oleConn.Open();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message); //如果有错误，输出错误信息 
            }
        }
        //断开数据库连接
        public void AccessDisConn(ref OleDbConnection oleConn)
        {
            try
            {
                oleConn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message); //如果有错误，输出错误信息 
            }
        }
        //读取学生基本信息
        public DataSet GetStudentBasicInfo(OleDbConnection oleConn)
        {
            AccessConn(ref oleConn);
            OleDbDataAdapter oleAdapt=new OleDbDataAdapter("select * from StudentBasicInfo",oleConn);
            DataSet ds=new DataSet();
            oleAdapt.Fill(ds,"StudentBasicInfo");
            AccessDisConn(ref oleConn);
            return ds;

        }
        //读取学生记录
        public DataSet GetStudentRecords(OleDbConnection oleConn)
        {
            AccessConn(ref oleConn);
            OleDbDataAdapter oleAdapt=new OleDbDataAdapter("select * from StudentRecords",oleConn);
            DataSet ds=new DataSet();
            oleAdapt.Fill(ds, "StudentRecords");
            AccessDisConn(ref oleConn);
            return ds;
        }
        /**/
        /// <summary>
        /// 执行SQL语句没有返回结果，如：执行删除、更新、插入等操作
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>操作成功标志</returns>
        public bool ExecuteNonQuery(string strSQL, OleDbConnection Connection)
        {
            bool resultState = false;

            AccessConn(ref Connection);
            OleDbTransaction myTrans = Connection.BeginTransaction();
            OleDbCommand command = new OleDbCommand(strSQL, Connection, myTrans);

            try
            {
                command.ExecuteNonQuery();
                myTrans.Commit();
                resultState = true;
            }
            catch
            {
                myTrans.Rollback();
                resultState = false;
            }
            finally
            {
                AccessDisConn(ref Connection);
            }
            return resultState;
        }
        /**/
        /// <summary>
        /// 执行SQL语句返回结果到DataReader中
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>dataReader</returns>
        public OleDbDataReader ExecuteDataReader(string strSQL, OleDbConnection Connection)
        {
            AccessConn(ref Connection);
            OleDbCommand command = new OleDbCommand(strSQL, Connection);
            OleDbDataReader dataReader = command.ExecuteReader();
            AccessDisConn(ref Connection);

            return dataReader;
        }
        /**/
        /// <summary>
        /// 执行SQL语句返回结果到DataSet中
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>DataSet</returns>
        public DataSet ExecuteDataSet(string strSQL, OleDbConnection Connection)
        {
            AccessConn(ref Connection);
            DataSet dataSet = new DataSet();
            OleDbDataAdapter OleDbDA = new OleDbDataAdapter(strSQL, Connection);
            OleDbDA.Fill(dataSet, "myDataSet");
            AccessDisConn(ref Connection);
            return dataSet;
        }

        /// <summary>
        /// 执行SQL语句返回结果到DataTable中
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string strSQL, OleDbConnection Connection)
        {
            return ExecuteDataSet(strSQL,Connection).Tables[0];
        }
        public DataRow ExecuteDataRow(string strSQL, OleDbConnection Connection)
        {
            DataTable dt = ExecuteDataTable(strSQL, Connection);
            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                return dr;
            }
            else
                return null;
        }
    }
}
