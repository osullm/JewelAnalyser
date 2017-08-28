using JewelApp01.Model;
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
    public delegate void ChangeLineIndexEventHander(int index);
    public partial class LineMover : Form
    {





        public LineMover()
        {
            InitializeComponent();
        }

        public AxTeeChart.AxTChart chart { set; get; }

        private int  chartIndex;
        public int ChartIndex {
            set
            {
                if (value > 1)
                {
                    chartIndex = value + 1;
                }
            }
            get
            {
                return chartIndex;
            }
        }

        private void moveUp()
        {
            if (chart.Series(chartIndex).XValues.Count > 0)
            {
                double[] xvalue = new double[chart.Series(chartIndex).XValues.Count], yvalue = new double[chart.Series(chartIndex).XValues.Count];
                double range = (chart.Series(chartIndex).YValues.Maximum - chart.Series(chartIndex).YValues.Minimum) * 0.02;

                for (int i = 0; i < chart.Series(chartIndex).XValues.Count; i++)
                {
                    xvalue[i] = chart.Series(chartIndex).XValues.Value[i];
                    yvalue[i] = chart.Series(chartIndex).YValues.Value[i] + range;
                }
                chart.Series(chartIndex).AddArray(xvalue.Length, yvalue, xvalue);
            }
        }

        private void moveDown()
        {
            if(chart.Series(chartIndex).XValues.Count>0)
            {
                double[] xvalue = new double[chart.Series(chartIndex).XValues.Count], yvalue = new double[chart.Series(chartIndex).XValues.Count];
                double range = (chart.Series(chartIndex).YValues.Maximum - chart.Series(chartIndex).YValues.Minimum) * 0.02;

                for (int i = 0; i < chart.Series(chartIndex).XValues.Count; i++)
                {
                    xvalue[i] = chart.Series(chartIndex).XValues.Value[i];
                    yvalue[i] = chart.Series(chartIndex).YValues.Value[i] - range;
                }
                chart.Series(chartIndex).AddArray(xvalue.Length, yvalue, xvalue);
            }
            
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            moveUp();
            timer1.Tag = 1;
            timer1.Start() ;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if((int)timer1.Tag==1)
            {
                moveUp();
            }
            else
            {
                moveDown();
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            moveDown();
            timer1.Tag = 0;
            timer1.Start();
           
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        public void setLineIndex(int index)
        {
            if (index >= 1)
            {
                chartIndex = index + 1;
            }
            else chartIndex = index;
        }
    }
}
