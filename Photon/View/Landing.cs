using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Photon.Controller;
using Photon.Model;
using Photon.Properties;


namespace Photon.View
{
    public partial class Landing : Form
    {

        public Landing()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.ssw128.GetHicon());
        }

        private void landingevent(object sender, EventArgs e)
        {

                String connsql = "Data Source=119.27.175.120;Initial Catalog = Digital Technology; Persist Security Info = True; User ID = sa;Password=dtserver"; // 数据库连接字符串,database设置为自己的数据库名，以Windows身份验证
                SqlConnection sqlConnection = new SqlConnection(connsql);
                sqlConnection.Open();
                //获取文本框中的值
                string username = Textboxuser.Text;
                string password = Textboxpass.Text;

            if (username.Equals("") || password.Equals(""))//用户名或密码为空
            {
                MessageBox.Show(I18N.GetString("Please enter your account or password.")); 
                //I18N.GetString("用户名或密码不能为空");
            }
            else//用户名或密码不为空
            {
                //到数据库中验证
                string selectSql = "select * from Photon_Users where Account=" + username+"and UserPwd=" + "'"+password+"'";
                //SqlDataAdapter sqlDa = new SqlDataAdapter(selectSql, sqlConnection);
                //DataTable dt = new DataTable();
                //sqlDa.Fill(dt);
                //int count = dt.Rows.Count;
                SqlCommand My_com = sqlConnection.CreateCommand();
                My_com.CommandText = selectSql;
                SqlDataReader My_Reader = My_com.ExecuteReader();
                SqlDataReader temdr = My_Reader;
                bool ifcom = temdr.Read();
                //if (ifcom)//如果信息>0则说明匹配成功
                //{
                //    Temporary merge branch 1
                //    MessageBox.Show("信息验证成功");
                //    staticusernanme = username;
                //}
                //else
                //{
                //    MessageBox.Show("用户名或密码错误");
                //    MessageBox.Show(I18N.GetString("登陆成功直接跳转主窗体") + count.ToString());      //Delete #53
                //}
                //else
                //{
                //    MessageBox.Show(I18N.GetString("Incorrect username or password.") + count.ToString());

                //    Temporary merge branch 2
                //}

            }
         
        }

        private void LinkLabows_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://photon.idigitaltechnology.com");
        }

        private void LinkLabUA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://photon.idigitaltechnology.com/Userknowledge/Userknowledge.html");
        }
    }
}
