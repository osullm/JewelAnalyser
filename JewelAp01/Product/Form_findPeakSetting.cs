using JewelApp01.Processer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelApp01.Product
{
    public partial class Form_findPeakSetting : Form
    {

        public ProcessSpec processSpec { set; get; }
        public Form_findPeakSetting()
        {
            InitializeComponent();
        }

        private void Form_findPeakSetting_Load(object sender, EventArgs e)
        {
            
            nud_smoothWidth.Value = processSpec.findPeakSmoothWidth;
            nud_peakWidth .Value = processSpec.findPeakWidth;
            nud_threshold .Value = processSpec.findPeakThreshold;
            cbx_Derection.SelectedIndex = processSpec.findPeakDerection;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processSpec.findPeakSmoothWidth = (int)nud_smoothWidth.Value;
            processSpec.findPeakWidth=(int)nud_peakWidth.Value ;
            processSpec.findPeakDerection=cbx_Derection.SelectedIndex ;
            processSpec.findPeakThreshold = (int)nud_threshold.Value;
            MessageBox.Show("设置成功！");
            Close();
        }
    }
}
