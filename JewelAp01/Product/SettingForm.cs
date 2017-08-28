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
    public partial class SettingForm : Form
    {

        public ProcessSpec processSpec { set; get; }
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            if(processSpec .IsConn )
            {
                numeric_InterTime.Value = processSpec.IntegrationTimeMS;
                numeric_average.Value = processSpec.AverageCounts;
                numeric_boxcar.Value = processSpec.BoxcarWidth;
                numeric_minWave.Value = (decimal)processSpec.ShowWavelength_MinMax[0];
                numeric_maxWave.Value = (decimal)processSpec.ShowWavelength_MinMax[1];
                //if (processSpec.TrigerState == true)
                //{
                    comboBox1.SelectedIndex = processSpec.TrigerState;
                //}
                //else
                //{
                //    comboBox1.SelectedIndex = 1;
                //}
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(processSpec.IsConn )
            {
                processSpec.IntegrationTimeMS = (int)numeric_InterTime.Value;
                processSpec.AverageCounts = (int)numeric_average.Value;
                processSpec.BoxcarWidth = (int)numeric_boxcar.Value;
                double[] minMaxWave = new double[2];
                minMaxWave[0] = (double)numeric_minWave.Value;
                minMaxWave[1] = (double)numeric_maxWave.Value;
                processSpec.ShowWavelength_MinMax = minMaxWave;
                
                    processSpec.TrigerState = comboBox1.SelectedIndex;
                
                MessageBox.Show("设置成功！");
            }
            else
            {
                MessageBox.Show("请连接设备！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
