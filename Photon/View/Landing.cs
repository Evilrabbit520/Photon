using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Photon.Controller;

namespace Photon.View
{
    public partial class Landing : Form
    {
        public Landing(object user)
        {
            InitializeComponent();
        }

        public Landing()
        {
        }

        private void UpdateTexts()
        {
            button1.Text = I18N.GetString("Landing");
        }

            private void button1_Click(object sender, EventArgs e)
            {

            }
    }
}
