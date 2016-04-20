using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web;
using System.IO;

namespace StudentManagement
{
    public class DatabaseConnection
    {
        /**/
        /// <summary>
        /// �������ݿ��ַ���
        /// </summary>
        private string connectionString;

        /**/
        /// <summary>
        /// �洢���ݿ����ӣ������ֻ࣬����������������ܷ��ʣ�
        /// </summary>
        protected OleDbConnection Connection;

        /**/
        /// <summary>
        /// ���캯�������ݿ��Ĭ������
        /// </summary>
        public DatabaseConnection()
        {
            string connStr;
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
            // connStr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"].ToString(); //��web.config�����ж�ȡ
            connectionString = connStr;
            //connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + HttpContext.Current.Request.PhysicalApplicationPath + connStr;       
            Connection = new OleDbConnection(connectionString);
        }

        /**/
        /// <summary>
        /// ���캯�������в��������ݿ�����
        /// </summary>
        /// <param name="newConnectionString"></param>
        public DatabaseConnection(string newConnectionString)
        {
            connectionString = newConnectionString;
            Connection = new OleDbConnection(connectionString);
        }

        /**/
        /// <summary>
        /// ��������ַ���
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        /**/
        /// <summary>
        /// ִ������������
        /// </summary>
        /// <param name="arrlist"></param>
        /// <returns></returns>
        public bool ExecuteBatch(ArrayList arrlist)
        {
            bool bFlag = true;
            string strSQL = string.Empty;

            Connection.Open();
            OleDbCommand command = null;
            using (OleDbTransaction myTrans = Connection.BeginTransaction())
            {
                try
                {
                    foreach (Object objSql in arrlist)
                    {
                        strSQL = objSql.ToString().Trim();
                        if (!string.IsNullOrEmpty(strSQL))
                            command = new OleDbCommand(strSQL, Connection, myTrans);
                    }
                    myTrans.Commit();
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    try
                    {
                        string lstrFileFolder = HttpContext.Current.Server.MapPath(@"~\log\");
                        string filename = "SqlErr_" + System.DateTime.Today.ToString("yyyyMMdd");
                        string path = lstrFileFolder + filename;
                        //�ж�Ŀ¼�Ƿ���ڣ������ھͽ��� 
                        if (!Directory.Exists(lstrFileFolder))
                        {
                            Directory.CreateDirectory(lstrFileFolder);
                        }
                        //д�ļ����ļ�������׷���ı����������򴴽����ļ�
                        FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter m_streamWriter = new StreamWriter(fs);
                        m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                        m_streamWriter.WriteLine(" =============== [" + System.DateTime.Now.ToString() + "] =============== ");
                        m_streamWriter.WriteLine(e.ToString());
                        m_streamWriter.WriteLine("---------------------------------------");
                        m_streamWriter.WriteLine(strSQL);
                        m_streamWriter.WriteLine("---------------------------------------");
                        m_streamWriter.WriteLine(" ");
                        m_streamWriter.Flush();
                        m_streamWriter.Close();
                    }
                    catch { }
                    bFlag = false;
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                    {
                        Connection.Close();
                    }
                    if (Connection != null)
                    {
                        Connection.Dispose();
                    }
                }
            }

            return bFlag;
        }

        /**/
        /// <summary>
        /// ִ��SQL���û�з��ؽ�����磺ִ��ɾ�������¡�����Ȳ���
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>�����ɹ���־</returns>
        public bool ExecuteNonQuery(string strSQL)
        {
            bool resultState = false;

            Connection.Open();
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
                Connection.Close();
            }
            return resultState;
        }

        /**/
        /// <summary>
        /// ִ��SQL��䷵�ؽ����DataReader��
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>dataReader</returns>
        public OleDbDataReader ExecuteDataReader(string strSQL)
        {
            Connection.Open();
            OleDbCommand command = new OleDbCommand(strSQL, Connection);
            OleDbDataReader dataReader = command.ExecuteReader();
            Connection.Close();

            return dataReader;
        }

        /**/
        /// <summary>
        /// ִ��SQL��䷵�ؽ����DataSet��
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>DataSet</returns>
        public DataSet ExecuteDataSet(string strSQL)
        {
            Connection.Open();
            DataSet dataSet = new DataSet();
            OleDbDataAdapter OleDbDA = new OleDbDataAdapter(strSQL, Connection);
            OleDbDA.Fill(dataSet, "myDataSet");

            Connection.Close();
            return dataSet;
        }

        /**/
        /// <summary>
        /// ִ��SQL��䷵�ؽ����DataTable��
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string strSQL)
        {
            return this.ExecuteDataSet(strSQL).Tables[0];
        }
    }
}

