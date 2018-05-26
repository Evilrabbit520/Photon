namespace Photon.View
{
    partial class CPUID
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
            this.BtnCPUID = new System.Windows.Forms.Button();
            this.TextCPUID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCPUID
            // 
            this.BtnCPUID.Location = new System.Drawing.Point(229, 135);
            this.BtnCPUID.Name = "BtnCPUID";
            this.BtnCPUID.Size = new System.Drawing.Size(97, 23);
            this.BtnCPUID.TabIndex = 0;
            this.BtnCPUID.Text = "显示CPU序列号";
            this.BtnCPUID.UseVisualStyleBackColor = true;
            this.BtnCPUID.Click += new System.EventHandler(this.BtnCPUID_Click);
            // 
            // TextCPUID
            // 
            this.TextCPUID.Location = new System.Drawing.Point(1, 135);
            this.TextCPUID.Name = "TextCPUID";
            this.TextCPUID.Size = new System.Drawing.Size(222, 21);
            this.TextCPUID.TabIndex = 1;
            this.TextCPUID.TextChanged += new System.EventHandler(this.TextCPUID_TextChanged);
            // 
            // CPUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextCPUID);
            this.Controls.Add(this.BtnCPUID);
            this.Name = "CPUID";
            this.Text = "CPUID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCPUID;
        private System.Windows.Forms.TextBox TextCPUID;
    }
}