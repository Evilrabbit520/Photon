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
                MessageBox.Show("用户名或密码不能为空");
            }
            else//用户名或密码不为空
            {
                //到数据库中验证
                string selectSql = "select * from Photon_Users where Account=" + username+"and UserPwd="+ "'"+password+"'";

                SqlDataAdapter sqlDa = new SqlDataAdapter(selectSql, sqlConnection);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                int count = dt.Rows.Count;
                if (count > 0)//如果信息>0则说明匹配成功
                {
                    MessageBox.Show("信息验证成功" + count.ToString());
                }
                else
                {
                    MessageBox.Show("用户名或密码错误"+count.ToString());
                }

            }
         
        }
    }
}
