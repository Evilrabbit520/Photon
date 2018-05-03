using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL_Photon
{
    class DataBase
    {
        public static string Login_ID = "";
        public static string Login_Name = "";
        public static SqlConnection My_Conn;
        public static string openConnstr = "Data Source=119.27.175.120;Initial Catalog = Digital Technology; Persist Security Info = True; User ID = sa;Password=dtserver";

        public static SqlConnection getcon()
        {
            My_Conn = new SqlConnection(openConnstr);
            My_Conn.Open();
            return My_Conn;
        }

        public void con_open()
        {
            getcon();
        }


        public void conn_close()
        {
            if (My_Conn.State == ConnectionState.Open)
            {
                My_Conn.Close();
                My_Conn.Dispose();
            }
        }

        public SqlDataReader getsdr(string sqlstr)
        {
            getcon();
            SqlCommand My_com = My_Conn.CreateCommand();
            My_com.CommandText = sqlstr;
            SqlDataReader My_Reader = My_com.ExecuteReader();
            return My_Reader;
        }

        public void dosqlcom(string sqlstr)
        {
            getcon();
            SqlCommand sqlcom = new SqlCommand(sqlstr, My_Conn);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            conn_close();
        }

        public DataSet getDs(string sqlstr, string tableName)
        {
            getcon();
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlstr, My_Conn);
            DataSet My_DataSet = new DataSet();
            sqlda.Fill(My_DataSet, tableName);
            conn_close();
            return My_DataSet;
        }


    }
}
