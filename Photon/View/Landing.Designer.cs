namespace Photon.View
{
    partial class Landing
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
            this.Btnlan = new System.Windows.Forms.Button();
            this.Textboxuser = new System.Windows.Forms.TextBox();
            this.Textboxpass = new System.Windows.Forms.TextBox();
            this.Labuser = new System.Windows.Forms.Label();
            this.LabPass = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImgPhotonlogo = new System.Windows.Forms.PictureBox();
            this.Imgphoton = new System.Windows.Forms.PictureBox();
            this.linkLablogin = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPhotonlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgphoton)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnlan
            // 
            this.Btnlan.Location = new System.Drawing.Point(166, 153);
            this.Btnlan.Name = "Btnlan";
            this.Btnlan.Size = new System.Drawing.Size(75, 35);
            this.Btnlan.TabIndex = 0;
            this.Btnlan.Text = "登陆";
            this.Btnlan.UseVisualStyleBackColor = true;
            // 
            // Textboxuser
            // 
            this.Textboxuser.Location = new System.Drawing.Point(90, 8);
            this.Textboxuser.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
            this.Textboxuser.Name = "Textboxuser";
            this.Textboxuser.Size = new System.Drawing.Size(143, 21);
            this.Textboxuser.TabIndex = 1;
            // 
            // Textboxpass
            // 
            this.Textboxpass.Location = new System.Drawing.Point(90, 45);
            this.Textboxpass.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
            this.Textboxpass.Name = "Textboxpass";
            this.Textboxpass.Size = new System.Drawing.Size(143, 21);
            this.Textboxpass.TabIndex = 1;
            this.Textboxpass.UseSystemPasswordChar = true;
            // 
            // Labuser
            // 
            this.Labuser.AutoSize = true;
            this.Labuser.Location = new System.Drawing.Point(12, 12);
            this.Labuser.Margin = new System.Windows.Forms.Padding(12);
            this.Labuser.Name = "Labuser";
            this.Labuser.Size = new System.Drawing.Size(59, 12);
            this.Labuser.TabIndex = 2;
            this.Labuser.Text = "Username:";
            // 
            // LabPass
            // 
            this.LabPass.AutoSize = true;
            this.LabPass.Location = new System.Drawing.Point(13, 50);
            this.LabPass.Margin = new System.Windows.Forms.Padding(13);
            this.LabPass.Name = "LabPass";
            this.LabPass.Size = new System.Drawing.Size(59, 11);
            this.LabPass.TabIndex = 2;
            this.LabPass.Text = "Password:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Labuser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Textboxpass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabPass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Textboxuser, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 74);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ImgPhotonlogo
            // 
            this.ImgPhotonlogo.Image = global::Photon.Properties.Resources.PhotonLogo1;
            this.ImgPhotonlogo.Location = new System.Drawing.Point(36, 1);
            this.ImgPhotonlogo.Name = "ImgPhotonlogo";
            this.ImgPhotonlogo.Size = new System.Drawing.Size(48, 46);
            this.ImgPhotonlogo.TabIndex = 4;
            this.ImgPhotonlogo.TabStop = false;
            // 
            // Imgphoton
            // 
            this.Imgphoton.Image = global::Photon.Properties.Resources.logo;
            this.Imgphoton.Location = new System.Drawing.Point(90, 12);
            this.Imgphoton.Name = "Imgphoton";
            this.Imgphoton.Size = new System.Drawing.Size(151, 39);
            this.Imgphoton.TabIndex = 5;
            this.Imgphoton.TabStop = false;
            // 
            // linkLablogin
            // 
            this.linkLablogin.AutoSize = true;
            this.linkLablogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLablogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLablogin.Location = new System.Drawing.Point(266, 81);
            this.linkLablogin.Name = "linkLablogin";
            this.linkLablogin.Size = new System.Drawing.Size(53, 12);
            this.linkLablogin.TabIndex = 6;
            this.linkLablogin.TabStop = true;
            this.linkLablogin.Text = "免费注册";
            this.linkLablogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 211);
            this.Controls.Add(this.linkLablogin);
            this.Controls.Add(this.Imgphoton);
            this.Controls.Add(this.ImgPhotonlogo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Btnlan);
            this.Name = "Landing";
            this.Text = "Landing";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPhotonlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgphoton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnlan;
        private System.Windows.Forms.TextBox Textboxpass;
        private System.Windows.Forms.Label Labuser;
        private System.Windows.Forms.Label LabPass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ImgPhotonlogo;
        protected internal System.Windows.Forms.TextBox Textboxuser;
        private System.Windows.Forms.PictureBox Imgphoton;
        private System.Windows.Forms.LinkLabel linkLablogin;
    }
}