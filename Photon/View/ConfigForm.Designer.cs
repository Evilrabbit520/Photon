namespace Photon.View
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.ShowPasswdCheckBox = new System.Windows.Forms.CheckBox();
            this.RemarksLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EncryptionLabel = new System.Windows.Forms.Label();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ServersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ProxyPortLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.UserHelpGroupBox = new System.Windows.Forms.GroupBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CenBtn = new System.Windows.Forms.Button();
            this.MoveUpBtn = new System.Windows.Forms.Button();
            this.MoveDownBtn = new System.Windows.Forms.Button();
            this.DuplicateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EncryptionSelect = new System.Windows.Forms.ComboBox();
            this.ProxyPortTextBox = new System.Windows.Forms.TextBox();
            this.TimeoutTextBox = new System.Windows.Forms.TextBox();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.ProtocolLabel = new System.Windows.Forms.Label();
            this.ProtocolBox = new System.Windows.Forms.ComboBox();
            this.LabTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProtocolparamLabel = new System.Windows.Forms.Label();
            this.ProtocolparamBox = new System.Windows.Forms.TextBox();
            this.ConfusedLabel = new System.Windows.Forms.Label();
            this.ConfusedBox = new System.Windows.Forms.ComboBox();
            this.ConfusedparamLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.UserHelpGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowPasswdCheckBox
            // 
            this.ShowPasswdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowPasswdCheckBox.AutoSize = true;
            this.ShowPasswdCheckBox.Location = new System.Drawing.Point(541, 199);
            this.ShowPasswdCheckBox.Name = "ShowPasswdCheckBox";
            this.ShowPasswdCheckBox.Size = new System.Drawing.Size(102, 16);
            this.ShowPasswdCheckBox.TabIndex = 16;
            this.ShowPasswdCheckBox.Text = "Show Password";
            this.ShowPasswdCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowPasswdCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswdCheckBox.Visible = false;
            this.ShowPasswdCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswdCheckBox_CheckedChanged);
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Location = new System.Drawing.Point(64, 249);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(47, 12);
            this.RemarksLabel.TabIndex = 9;
            this.RemarksLabel.Text = "Remarks";
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(52, 9);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(59, 12);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "Server IP";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(40, 39);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(71, 12);
            this.ServerPortLabel.TabIndex = 1;
            this.ServerPortLabel.Text = "Server Port";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(58, 69);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 12);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncryptionLabel
            // 
            this.EncryptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EncryptionLabel.AutoSize = true;
            this.EncryptionLabel.Location = new System.Drawing.Point(46, 99);
            this.EncryptionLabel.Name = "EncryptionLabel";
            this.EncryptionLabel.Size = new System.Drawing.Size(65, 12);
            this.EncryptionLabel.TabIndex = 8;
            this.EncryptionLabel.Text = "Encryption";
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(34, 279);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeoutLabel.Size = new System.Drawing.Size(77, 12);
            this.TimeoutLabel.TabIndex = 10;
            this.TimeoutLabel.Text = "Timeout(Sec)";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(429, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // ServersListBox
            // 
            this.ServersListBox.FormattingEnabled = true;
            this.ServersListBox.IntegralHeight = false;
            this.ServersListBox.ItemHeight = 12;
            this.ServersListBox.Location = new System.Drawing.Point(0, 0);
            this.ServersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ServersListBox.Name = "ServersListBox";
            this.ServersListBox.Size = new System.Drawing.Size(211, 315);
            this.ServersListBox.TabIndex = 0;
            this.ServersListBox.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ServersListBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 315);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 315);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(211, 0);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 315);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(211, 0);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // ProxyPortLabel
            // 
            this.ProxyPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProxyPortLabel.AutoSize = true;
            this.ProxyPortLabel.Location = new System.Drawing.Point(46, 329);
            this.ProxyPortLabel.Name = "ProxyPortLabel";
            this.ProxyPortLabel.Size = new System.Drawing.Size(65, 12);
            this.ProxyPortLabel.TabIndex = 3;
            this.ProxyPortLabel.Text = "Proxy Port";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Location = new System.Drawing.Point(6, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(328, 151);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // UserHelpGroupBox
            // 
            this.UserHelpGroupBox.Controls.Add(this.richTextBox1);
            this.UserHelpGroupBox.Location = new System.Drawing.Point(535, 13);
            this.UserHelpGroupBox.Name = "UserHelpGroupBox";
            this.UserHelpGroupBox.Size = new System.Drawing.Size(340, 177);
            this.UserHelpGroupBox.TabIndex = 9;
            this.UserHelpGroupBox.TabStop = false;
            this.UserHelpGroupBox.Text = "User Help";
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.SystemColors.Control;
            this.OKBtn.Location = new System.Drawing.Point(352, 390);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 6;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CenBtn
            // 
            this.CenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CenBtn.Location = new System.Drawing.Point(442, 390);
            this.CenBtn.Name = "CenBtn";
            this.CenBtn.Size = new System.Drawing.Size(75, 23);
            this.CenBtn.TabIndex = 7;
            this.CenBtn.Text = "Cancel";
            this.CenBtn.UseVisualStyleBackColor = false;
            this.CenBtn.Click += new System.EventHandler(this.CenBtn_Click);
            // 
            // MoveUpBtn
            // 
            this.MoveUpBtn.BackColor = System.Drawing.SystemColors.Control;
            this.MoveUpBtn.Location = new System.Drawing.Point(12, 390);
            this.MoveUpBtn.Name = "MoveUpBtn";
            this.MoveUpBtn.Size = new System.Drawing.Size(75, 23);
            this.MoveUpBtn.TabIndex = 3;
            this.MoveUpBtn.Text = "Move &Up";
            this.MoveUpBtn.UseVisualStyleBackColor = false;
            this.MoveUpBtn.Click += new System.EventHandler(this.MoveUpBtn_Click);
            // 
            // MoveDownBtn
            // 
            this.MoveDownBtn.BackColor = System.Drawing.SystemColors.Control;
            this.MoveDownBtn.Location = new System.Drawing.Point(148, 390);
            this.MoveDownBtn.Name = "MoveDownBtn";
            this.MoveDownBtn.Size = new System.Drawing.Size(75, 23);
            this.MoveDownBtn.TabIndex = 5;
            this.MoveDownBtn.Text = "Move &Down";
            this.MoveDownBtn.UseVisualStyleBackColor = false;
            this.MoveDownBtn.Click += new System.EventHandler(this.MoveDownBtn_Click);
            // 
            // DuplicateBtn
            // 
            this.DuplicateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DuplicateBtn.Location = new System.Drawing.Point(12, 361);
            this.DuplicateBtn.Name = "DuplicateBtn";
            this.DuplicateBtn.Size = new System.Drawing.Size(75, 23);
            this.DuplicateBtn.TabIndex = 2;
            this.DuplicateBtn.Text = "&Duplicate";
            this.DuplicateBtn.UseVisualStyleBackColor = false;
            this.DuplicateBtn.Click += new System.EventHandler(this.DuplicateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.Location = new System.Drawing.Point(12, 332);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "&Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.Location = new System.Drawing.Point(148, 332);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "&Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.IPLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IPTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServerPortLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ServerPortTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionSelect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ProxyPortLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.ProxyPortTextBox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.TimeoutLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.TimeoutTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.RemarksLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.RemarksTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.ProtocolLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ProtocolBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ProtocolparamLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ProtocolparamBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ConfusedLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ConfusedBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ConfusedparamLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(232, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.Location = new System.Drawing.Point(117, 4);
            this.IPTextBox.MaxLength = 512;
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(165, 21);
            this.IPTextBox.TabIndex = 0;
            this.IPTextBox.WordWrap = false;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPortTextBox.Location = new System.Drawing.Point(117, 34);
            this.ServerPortTextBox.MaxLength = 10;
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(165, 21);
            this.ServerPortTextBox.TabIndex = 1;
            this.ServerPortTextBox.WordWrap = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(117, 64);
            this.PasswordTextBox.MaxLength = 256;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(165, 21);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WordWrap = false;
            // 
            // EncryptionSelect
            // 
            this.EncryptionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptionSelect.FormattingEnabled = true;
            this.EncryptionSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EncryptionSelect.ItemHeight = 12;
            this.EncryptionSelect.Items.AddRange(new object[] {
            "rc4-md5",
            "aes-256-cfb",
            "aes-128-gcm"});
            this.EncryptionSelect.Location = new System.Drawing.Point(117, 93);
            this.EncryptionSelect.Name = "EncryptionSelect";
            this.EncryptionSelect.Size = new System.Drawing.Size(165, 20);
            this.EncryptionSelect.TabIndex = 3;
            // 
            // ProxyPortTextBox
            // 
            this.ProxyPortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProxyPortTextBox.Location = new System.Drawing.Point(117, 325);
            this.ProxyPortTextBox.MaxLength = 10;
            this.ProxyPortTextBox.Name = "ProxyPortTextBox";
            this.ProxyPortTextBox.Size = new System.Drawing.Size(113, 21);
            this.ProxyPortTextBox.TabIndex = 9;
            this.ProxyPortTextBox.WordWrap = false;
            // 
            // TimeoutTextBox
            // 
            this.TimeoutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeoutTextBox.Location = new System.Drawing.Point(117, 274);
            this.TimeoutTextBox.MaxLength = 5;
            this.TimeoutTextBox.Name = "TimeoutTextBox";
            this.TimeoutTextBox.Size = new System.Drawing.Size(165, 21);
            this.TimeoutTextBox.TabIndex = 8;
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksTextBox.Location = new System.Drawing.Point(117, 244);
            this.RemarksTextBox.MaxLength = 32;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(165, 21);
            this.RemarksTextBox.TabIndex = 7;
            this.RemarksTextBox.WordWrap = false;
            // 
            // ProtocolLabel
            // 
            this.ProtocolLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProtocolLabel.AutoSize = true;
            this.ProtocolLabel.Location = new System.Drawing.Point(58, 129);
            this.ProtocolLabel.Name = "ProtocolLabel";
            this.ProtocolLabel.Size = new System.Drawing.Size(53, 12);
            this.ProtocolLabel.TabIndex = 27;
            this.ProtocolLabel.Text = "Protocol";
            // 
            // ProtocolBox
            // 
            this.ProtocolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProtocolBox.BackColor = System.Drawing.Color.White;
            this.ProtocolBox.FormattingEnabled = true;
            this.ProtocolBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProtocolBox.ItemHeight = 12;
            this.ProtocolBox.Items.AddRange(new object[] {
            "origin",
            "verify_deflate",
            "auth_sha1_v4",
            "auth_aes128_md5",
            "auth_aes128_sha1",
            "auth_chain_a",
            "auth_chain_b",
            "auth_chain_c",
            "auth_chain_d"});
            this.ProtocolBox.Location = new System.Drawing.Point(117, 123);
            this.ProtocolBox.Name = "ProtocolBox";
            this.ProtocolBox.Size = new System.Drawing.Size(165, 20);
            this.ProtocolBox.TabIndex = 3;
            // 
            // LabTime
            // 
            this.LabTime.AutoSize = true;
            this.LabTime.Font = new System.Drawing.Font("华文行楷", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTime.ForeColor = System.Drawing.Color.Gray;
            this.LabTime.Location = new System.Drawing.Point(684, 257);
            this.LabTime.Name = "LabTime";
            this.LabTime.Size = new System.Drawing.Size(146, 19);
            this.LabTime.TabIndex = 26;
            this.LabTime.Text = "Time：-/-/- -:-:-";
            this.LabTime.Click += new System.EventHandler(this.LabTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProtocolparamLabel
            // 
            this.ProtocolparamLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProtocolparamLabel.AutoSize = true;
            this.ProtocolparamLabel.Location = new System.Drawing.Point(22, 159);
            this.ProtocolparamLabel.Name = "ProtocolparamLabel";
            this.ProtocolparamLabel.Size = new System.Drawing.Size(89, 12);
            this.ProtocolparamLabel.TabIndex = 27;
            this.ProtocolparamLabel.Text = "Protocol param";
            // 
            // ProtocolparamBox
            // 
            this.ProtocolparamBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProtocolparamBox.Location = new System.Drawing.Point(117, 154);
            this.ProtocolparamBox.MaxLength = 256;
            this.ProtocolparamBox.Name = "ProtocolparamBox";
            this.ProtocolparamBox.Size = new System.Drawing.Size(165, 21);
            this.ProtocolparamBox.TabIndex = 2;
            this.ProtocolparamBox.UseSystemPasswordChar = true;
            this.ProtocolparamBox.WordWrap = false;
            // 
            // ConfusedLabel
            // 
            this.ConfusedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfusedLabel.AutoSize = true;
            this.ConfusedLabel.Location = new System.Drawing.Point(58, 189);
            this.ConfusedLabel.Name = "ConfusedLabel";
            this.ConfusedLabel.Size = new System.Drawing.Size(53, 12);
            this.ConfusedLabel.TabIndex = 27;
            this.ConfusedLabel.Text = "Confused";
            // 
            // ConfusedBox
            // 
            this.ConfusedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfusedBox.BackColor = System.Drawing.Color.White;
            this.ConfusedBox.FormattingEnabled = true;
            this.ConfusedBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConfusedBox.ItemHeight = 12;
            this.ConfusedBox.Items.AddRange(new object[] {
            "plain",
            "http_simple",
            "http_post",
            "random_head",
            "tls1.2_ticket_auth",
            "tls1.2_ticket_fastauth"});
            this.ConfusedBox.Location = new System.Drawing.Point(117, 183);
            this.ConfusedBox.Name = "ConfusedBox";
            this.ConfusedBox.Size = new System.Drawing.Size(165, 20);
            this.ConfusedBox.TabIndex = 3;
            // 
            // ConfusedparamLabel
            // 
            this.ConfusedparamLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfusedparamLabel.AutoSize = true;
            this.ConfusedparamLabel.Location = new System.Drawing.Point(22, 219);
            this.ConfusedparamLabel.Name = "ConfusedparamLabel";
            this.ConfusedparamLabel.Size = new System.Drawing.Size(89, 12);
            this.ConfusedparamLabel.TabIndex = 27;
            this.ConfusedparamLabel.Text = "Confused param";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(117, 214);
            this.textBox1.MaxLength = 256;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.WordWrap = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(891, 443);
            this.Controls.Add(this.LabTime);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DuplicateBtn);
            this.Controls.Add(this.MoveDownBtn);
            this.Controls.Add(this.MoveUpBtn);
            this.Controls.Add(this.CenBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ShowPasswdCheckBox);
            this.Controls.Add(this.UserHelpGroupBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(12, 12, 12, 9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure the photon server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigForm_KeyDown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.UserHelpGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label ServerPortLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EncryptionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox ServersListBox;
        private System.Windows.Forms.Label RemarksLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label ProxyPortLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label TimeoutLabel;
        private System.Windows.Forms.CheckBox ShowPasswdCheckBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox UserHelpGroupBox;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CenBtn;
        private System.Windows.Forms.Button MoveUpBtn;
        private System.Windows.Forms.Button MoveDownBtn;
        private System.Windows.Forms.Button DuplicateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ComboBox EncryptionSelect;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.TextBox TimeoutTextBox;
        private System.Windows.Forms.TextBox ProxyPortTextBox;
        private System.Windows.Forms.Label LabTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ProtocolLabel;
        private System.Windows.Forms.ComboBox ProtocolBox;
        private System.Windows.Forms.Label ProtocolparamLabel;
        private System.Windows.Forms.TextBox ProtocolparamBox;
        private System.Windows.Forms.Label ConfusedLabel;
        private System.Windows.Forms.ComboBox ConfusedBox;
        private System.Windows.Forms.Label ConfusedparamLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

