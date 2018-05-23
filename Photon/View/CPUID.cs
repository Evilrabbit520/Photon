using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Photon.View
{
    public partial class CPUID : Form
    {
        public CPUID()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取CPUID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCPUID_Click(object sender, EventArgs e)
        {
            string GetCpuID()
            {
                try
                {
                    string cpuInfo = "";//cpu序列号 
                    ManagementClass mc = new ManagementClass("Win32_Processor");
                    ManagementObjectCollection moc = mc.GetInstances();
                    foreach (ManagementObject mo in moc)
                    {
                        cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                    }
                    moc = null;
                    mc = null;
                    return cpuInfo;
                }
                catch
                {
                    return "unknow";
                }
            }
            
            TextCPUID.Text = GetCpuID();
        }

        private void TextCPUID_TextChanged(object sender, EventArgs e)
        {
             //这里可以Delete了，没用了
        }
    }
}
