using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace StudentManagement
{
    /// <summary>
    /// ���ݿ�����
    /// </summary>
    class DBConnection
    {
        //�����ַ���
        private string ConStr="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\Data\\Student.mdb;Persist Security Info=True;Jet OLEDB:Database Password=xbsun";
        //�������ݿ�
        public void AccessConn(ref OleDbConnection oleConn)
        {
            try
            {
                oleConn = new OleDbConnection(ConStr);
                oleConn.Open();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message); //����д������������Ϣ 
            }
        }
        //�Ͽ����ݿ�����
        public void AccessDisConn(ref OleDbConnection oleConn)
        {
            try
            {
                oleConn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message); //����д������������Ϣ 
            }
        }
        //��ȡѧ��������Ϣ
        public DataSet GetStudentBasicInfo(OleDbConnection oleConn)
        {
            AccessConn(ref oleConn);
            OleDbDataAdapter oleAdapt=new OleDbDataAdapter("select * from StudentBasicInfo",oleConn);
            DataSet ds=new DataSet();
            oleAdapt.Fill(ds,"StudentBasicInfo");
            AccessDisConn(ref oleConn);
            return ds;

        }
        //��ȡѧ����¼
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
        /// ִ��SQL���û�з��ؽ�����磺ִ��ɾ�������¡�����Ȳ���
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>�����ɹ���־</returns>
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
        /// ִ��SQL��䷵�ؽ����DataReader��
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
        /// ִ��SQL��䷵�ؽ����DataSet��
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
        /// ִ��SQL��䷵�ؽ����DataTable��
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
