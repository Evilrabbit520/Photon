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

namespace Photon.View
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connsql = "Data Source=119.27.175.120;Initial Catalog = Digital Technology; Persist Security Info = True; User ID = sa;Password=dtserver"; // 数据库连接字符串,database设置为自己的数据库名，以Windows身份验证

            try
            {
                SqlConnection sqlConnection = new SqlConnection(connsql);
                sqlConnection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Photon_Users", sqlConnection);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
                //SqlCommand sqlCmd = new SqlCommand("insert into tb_scene_tb (id,scene_id) values('1','123')", sqlConnection);
                //sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息：" + ex.Message, "出现错误");
            }

        }
    }
}
