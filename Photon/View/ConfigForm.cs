using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using Photon.Controller;
using Photon.Model;
using Photon.Properties;
using System.Data.SqlClient;
using MODEL_Photon;

namespace Photon.View
{
    public partial class ConfigForm : Form
    {
        private PhotonController controller;
        // this is a copy of configuration that we are working on
        private Configuration _modifiedConfiguration;
        private int _lastSelectedIndex = -1;

        public ConfigForm(PhotonController controller)
        {
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            InitializeComponent();
            
            // a dirty hack
            this.ServersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerformLayout();
            UpdateTexts();
            this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());
            this.controller = controller;
            controller.ConfigChanged += controller_ConfigChanged;
            LoadCurrentConfiguration();
            label2.Text = Landing.staticusernanme;
        }

        public ConfigForm()
        {
        }

        private void UpdateTexts()
        {
            AddBtn.Text = I18N.GetString("&Add");
            DeleteBtn.Text = I18N.GetString("&Delete");
            DuplicateBtn.Text = I18N.GetString("Dupli&cate");
            IPLabel.Text = I18N.GetString("Server Addr");
            ServerPortLabel.Text = I18N.GetString("Server Port");
            PasswordLabel.Text = I18N.GetString("Password");
            ShowPasswdCheckBox.Text = I18N.GetString("Show Password");
            EncryptionLabel.Text = I18N.GetString("Encryption");
            LabConf.Text = I18N.GetString("Confused");
            LabConP.Text = I18N.GetString("Confusion par");
            PluginLabel.Text = I18N.GetString("Plugin");
            PluginOptionsLabel.Text = I18N.GetString("Plugin Options");
            ProxyPortLabel.Text = I18N.GetString("Proxy Port");
            RemarksLabel.Text = I18N.GetString("Remarks");
            TimeoutLabel.Text = I18N.GetString("Timeout(Sec)");
            //ServerGroupBox.Text = I18N.GetString("Server");
            OKBtn.Text = I18N.GetString("OK");
            CenBtn.Text = I18N.GetString("Cancel");
            MoveUpBtn.Text = I18N.GetString("Move &Up");
            MoveDownBtn.Text = I18N.GetString("Move D&own");
            UserHelpGroupBox.Text = I18N.GetString("User help");
            //btnGC.Text = I18N.GetString("OK");
            //textGC.Text = I18N.GetString("Gift Certificate");
            this.Text = I18N.GetString("Configure the photon server");
        }

        private void controller_ConfigChanged(object sender, EventArgs e)
        {
            LoadCurrentConfiguration();
        }

        private void ShowWindow()
        {
            this.Opacity = 1;
            this.Show();
            IPTextBox.Focus();
        }

        private bool SaveOldSelectedServer()
        {
            try
            {
                if (_lastSelectedIndex == -1 || _lastSelectedIndex >= _modifiedConfiguration.configs.Count)
                {
                    return true;
                }
                Server server = new Server();

                if (Uri.CheckHostName(server.server = IPTextBox.Text.Trim()) == UriHostNameType.Unknown)
                {
                    MessageBox.Show(I18N.GetString("Invalid server address"));
                    IPTextBox.Focus();
                    return false;
                }
                if (!int.TryParse(ServerPortTextBox.Text, out server.server_port))
                {
                    MessageBox.Show(I18N.GetString("Illegal port number format"));
                    ServerPortTextBox.Focus();
                    return false;
                }
                server.password = PasswordTextBox.Text;
                server.method = EncryptionSelect.Text;
                server.plugin = PluginTextBox.Text;
                server.plugin_opts = PluginOptionsTextBox.Text;
                server.remarks = RemarksTextBox.Text;
                if (!int.TryParse(TimeoutTextBox.Text, out server.timeout))
                {
                    MessageBox.Show(I18N.GetString("Illegal timeout format"));
                    TimeoutTextBox.Focus();
                    return false;
                }
                int localPort = int.Parse(ProxyPortTextBox.Text);
                Configuration.CheckServer(server);
                Configuration.CheckLocalPort(localPort);
                _modifiedConfiguration.configs[_lastSelectedIndex] = server;
                _modifiedConfiguration.localPort = localPort;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void LoadSelectedServer()
        {
            if (ServersListBox.SelectedIndex >= 0 && ServersListBox.SelectedIndex < _modifiedConfiguration.configs.Count)
            {
                Server server = _modifiedConfiguration.configs[ServersListBox.SelectedIndex];

                IPTextBox.Text = server.server;
                ServerPortTextBox.Text = server.server_port.ToString();
                PasswordTextBox.Text = server.password;
                ProxyPortTextBox.Text = _modifiedConfiguration.localPort.ToString();
                EncryptionSelect.Text = server.method ?? "aes-256-cfb";
                PluginTextBox.Text = server.plugin;
                PluginOptionsTextBox.Text = server.plugin_opts;
                RemarksTextBox.Text = server.remarks;
                TimeoutTextBox.Text = server.timeout.ToString();
            }
            if (ServersListBox.SelectedIndex >= 0 && ServersListBox.SelectedIndex < _modifiedConfiguration.configs.Count)
            {
                Server server = _modifiedConfiguration.configs[ServersListBox.SelectedIndex];

                string obfs_text = server.obfs ?? "plain";
                ConfusedBox.Text = obfs_text;
                PluginOptionsTextBox.Text = server.obfsparam;
                RemarksTextBox.Text = server.remarks;
            }

        }


        private void LoadConfiguration(Configuration configuration)
        {
            ServersListBox.Items.Clear();
            foreach (Server server in _modifiedConfiguration.configs)
            {
                ServersListBox.Items.Add(server.FriendlyName());
            }
        }

        private void LoadCurrentConfiguration()
        {
            _modifiedConfiguration = controller.GetConfigurationCopy();
            LoadConfiguration(_modifiedConfiguration);
            _lastSelectedIndex = _modifiedConfiguration.index;
            if (_lastSelectedIndex < 0 || _lastSelectedIndex >= ServersListBox.Items.Count)
            {
                _lastSelectedIndex = 0;
            }
            ServersListBox.SelectedIndex = _lastSelectedIndex;
            UpdateMoveUpAndDownButton();
            LoadSelectedServer();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfigForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Sometimes the users may hit enter key by mistake, and the form will close without saving entries.

            if (e.KeyCode == Keys.Enter)
            {
                Server server = controller.GetCurrentServer();
                if (!SaveOldSelectedServer())
                {
                    return;
                }
                if (_modifiedConfiguration.configs.Count == 0)
                {
                    MessageBox.Show(I18N.GetString("Please add at least one server"));
                    return;
                }
                controller.SaveServers(_modifiedConfiguration.configs, _modifiedConfiguration.localPort);
                controller.SelectServerIndex(_modifiedConfiguration.configs.IndexOf(server));
            }

        }

        private void ServersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ServersListBox.CanSelect)
            {
                return;
            }
            if (_lastSelectedIndex == ServersListBox.SelectedIndex)
            {
                // we are moving back to oldSelectedIndex or doing a force move
                return;
            }
            if (!SaveOldSelectedServer())
            {
                // why this won't cause stack overflow?
                ServersListBox.SelectedIndex = _lastSelectedIndex;
                return;
            }
            if (_lastSelectedIndex >= 0)
            {
                ServersListBox.Items[_lastSelectedIndex] = _modifiedConfiguration.configs[_lastSelectedIndex].FriendlyName();
            }
            UpdateMoveUpAndDownButton();
            LoadSelectedServer();
            _lastSelectedIndex = ServersListBox.SelectedIndex;
        }


        private void ConfigForm_Shown(object sender, EventArgs e)
        {
            IPTextBox.Focus();
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.ConfigChanged -= controller_ConfigChanged;
        }

        private void MoveConfigItem(int step)
        {
            int index = ServersListBox.SelectedIndex;
            Server server = _modifiedConfiguration.configs[index];
            object item = ServersListBox.Items[index];

            _modifiedConfiguration.configs.Remove(server);
            _modifiedConfiguration.configs.Insert(index + step, server);
            _modifiedConfiguration.index += step;

            ServersListBox.BeginUpdate();
            ServersListBox.Enabled = false;
            _lastSelectedIndex = index + step;
            ServersListBox.Items.Remove(item);
            ServersListBox.Items.Insert(index + step, item);
            ServersListBox.Enabled = true;
            ServersListBox.SelectedIndex = index + step;
            ServersListBox.EndUpdate();

            UpdateMoveUpAndDownButton();
        }

        private void UpdateMoveUpAndDownButton()
        {
            if (ServersListBox.SelectedIndex == 0)
            {
                MoveUpBtn.Enabled = false;
            }
            else
            {
                MoveUpBtn.Enabled = true;
            }
            if (ServersListBox.SelectedIndex == ServersListBox.Items.Count - 1)
            {
                MoveDownBtn.Enabled = false;
            }
            else
            {
                MoveDownBtn.Enabled = true;
            }
        }

        private void ShowPasswdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //this.PasswordTextBox.UseSystemPasswordChar = !this.ShowPasswdCheckBox.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void labGC_Click(object sender, EventArgs e)
        {

        }

        //private void btnGC_Click(object sender, UserInfo user)
        //{
        //    //登录就在这里写了、

        //    //连接数据库比对，后面写三层架构的时候把数据库的操作写进去
        //    //SqlConnection con = new SqlConnection();
        //    //con.ConnectionString = "user id=Digital Technology;Data Source=mssql.ybj.pw,10120;database=Digital Technology;password=DigitalTechnology2017";
        //    //con.Open();
        //    //if (user.UserName == "")
        //    //{
        //    //    user.LoginMsg = "请输入账号或密码";
        //    //}
        //    //else
        //    //{
        //    //    SqlCommand com = new SqlCommand("select count(*) from Digital_Technology_Users where Account='" + user.UserName +"'", con);
        //    //    //com.CommandText = ;
        //    //    var a = com.ExecuteScalar();
        //    //    int num = Convert.ToInt32(a);
        //    //    if (num > 0)
        //    //    {
        //    //        con.Close();
        //    //        user.LoginFlag = true;
        //    //        user.LoginMsg = "开发账户登录成功";      //此处应该为动态检测 现在为静态
        //    //    }
        //    //    else
        //    //    {
        //    //        user.LoginMsg = "用户名或密码错误，请检查您的用户名或者密码";
        //    //    }
        //    //}
            
        //}

        //private void btnGC_Click(object sender, EventArgs e)
        //{
        //    //判断是否非空
        //    if (textGC.Text.Trim() == String.Empty)
        //    {
        //        //MessageBox.Show("您未输入的礼券码，请联系系统管理员获取礼券码","错误！");
        //        ////this.Close();     //关闭当前窗口
        //        //return;     //返回
        //        MessageBox.Show(I18N.GetString("If you have not entered your gift certificate code, please contact your system administrator to obtain the gift certificate code."));
        //        TimeoutTextBox.Focus();
        //        return;     //返回
        //    }
        //}


        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!SaveOldSelectedServer())
            {
                return;
            }
            if (_modifiedConfiguration.configs.Count == 0)
            {
                MessageBox.Show(I18N.GetString("Please add at least one server"));
                return;
            }
            controller.SaveServers(_modifiedConfiguration.configs, _modifiedConfiguration.localPort);
            // SelectedIndex remains valid
            // We handled this in event handlers, e.g. Add/DeleteButton, SelectedIndexChanged
            // and move operations
            controller.SelectServerIndex(ServersListBox.SelectedIndex);
            this.Close();

        }

        private void CenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            if (!SaveOldSelectedServer())
            {
                return;
            }
            if (ServersListBox.SelectedIndex > 0)
            {
                MoveConfigItem(-1);  // -1 means move backward
            }
        }

        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            if (!SaveOldSelectedServer())
            {
                return;
            }
            if (ServersListBox.SelectedIndex < ServersListBox.Items.Count - 1)
            {
                MoveConfigItem(+1);  // +1 means move forward
            }
        }

        private void DuplicateBtn_Click(object sender, EventArgs e)
        {
            
            if (!SaveOldSelectedServer())
            {
                return;
            }
            Server currServer = _modifiedConfiguration.configs[_lastSelectedIndex];
            var currIndex = _modifiedConfiguration.configs.IndexOf(currServer);
            _modifiedConfiguration.configs.Insert(currIndex + 1, currServer);
            LoadConfiguration(_modifiedConfiguration);
            ServersListBox.SelectedIndex = currIndex + 1;
            _lastSelectedIndex = ServersListBox.SelectedIndex;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (!SaveOldSelectedServer())
            {
                return;
            }
            Server server = Configuration.GetDefaultServer();
            _modifiedConfiguration.configs.Add(server);
            LoadConfiguration(_modifiedConfiguration);
            ServersListBox.SelectedIndex = _modifiedConfiguration.configs.Count - 1;
            _lastSelectedIndex = ServersListBox.SelectedIndex;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            _lastSelectedIndex = ServersListBox.SelectedIndex;
            if (_lastSelectedIndex >= 0 && _lastSelectedIndex < _modifiedConfiguration.configs.Count)
            {
                _modifiedConfiguration.configs.RemoveAt(_lastSelectedIndex);
            }
            if (_lastSelectedIndex >= _modifiedConfiguration.configs.Count)
            {
                // can be -1
                _lastSelectedIndex = _modifiedConfiguration.configs.Count - 1;
            }
            ServersListBox.SelectedIndex = _lastSelectedIndex;
            LoadConfiguration(_modifiedConfiguration);
            ServersListBox.SelectedIndex = _lastSelectedIndex;
            LoadSelectedServer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LabTime.Text = (I18N.GetString("Time：")) + DateTime.Now.ToString();
        }

        private void LabTime_Click(object sender, EventArgs e)
        {

        }

        private void PluginLabel_Click(object sender, EventArgs e)
        {

        }

        private void PluginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CPUID form1 = new CPUID();
            form1.Show();

        }
    }
}
