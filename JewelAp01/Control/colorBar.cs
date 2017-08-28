using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Collections.Generic;

namespace JewelApp01.Control
{
    public partial class colorBar : UserControl
    {
        [ToolboxItem(true)]

        private List<double> LineWavePos=new List<double> ();
        public Color [] colorArray;
        public float[] colorPosition;
        public colorBar()
        {
            InitializeComponent();
        }

        private void colorBar_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            getColorWaveArray();
            //ColorLoad();
        }

        private void colorBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Transparent, Color.Transparent, LinearGradientMode.Horizontal);

            ColorBlend blend = new ColorBlend();

            //blend.Colors = colors;
            blend.Positions = colorPosition;//pos;
            blend.Colors = colorArray;
            //blend.Positions = colorPosition;
            brush.InterpolationColors = blend;
            g.FillRectangle(brush, ClientRectangle);

            //drawLine(550);
        }

        public void drawLine(double wavePos)
        {
            LineWavePos.Add(wavePos);
            if (wavePos > 380 && wavePos < 780)
            {

                int width = this.ClientRectangle.Width;
                //double pos = width * 0.8 * (wave[i] - 380) / 400 + 0.1 * width;
                double pos = width*(wavePos - 200) / 800;
                Graphics g = this.CreateGraphics();
                //Pen p = new Pen(Color.FromArgb (150,128,128,128), 3.0f);

                //g.DrawLine(p, (float)pos, 0, (float)pos, 60);

                //Graphics g = ((PictureBox)sender).CreateGraphics();//创建画板
                //Rectangle rc = new Rectangle((int )pos-3, 0, ClientRectangle.Width - 20, ClientRectangle.Height - 10);
                //g.DrawRectangle(new Pen(Color.DarkBlue), rc);//画一个框
                SolidBrush sb = new SolidBrush(Color.FromArgb(80, 255, 255, 255));//创建半透明画刷
                Rectangle rc = new Rectangle((int)pos - 2, 0, 4, ClientRectangle.Height );
                g.FillRectangle(sb, rc);//填充


            }

        }
        public void removeLine(double wavePos)
        {

            LineWavePos.Remove (wavePos );
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            this.colorBar_Paint(new object(), new PaintEventArgs(g, ClientRectangle));

            for (int i = 0; i < LineWavePos.Count; i++)
            {
                if (LineWavePos[i] > 380 && LineWavePos[i] < 780)
                {
                    int width = this.ClientRectangle.Width;
                    //double pos = width * 0.8 * (wave[i] - 380) / 400 + 0.1 * width;
                    double pos = width * (LineWavePos[i] - 200) / 800;
                    //Graphics g = this.CreateGraphics();
                    Pen p = new Pen(Color.FromArgb(150, 128, 128, 128), 3.0f);

                    g.DrawLine(p, (float)pos, 0, (float)pos, 60);
                }
            }

        }

        public void clearLine()
        {
            LineWavePos.Clear();
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White );
            this.colorBar_Paint(new object() ,new  PaintEventArgs(g,ClientRectangle ) );

        }


            /// <summary>
            /// 从波长转换到颜色计算
            /// </summary>
            /// <param name="Wavelength">传入的波长</param>
            /// <returns></returns>
        private Color WavelenghToRGB(int Wavelength)
        {
            double Gamma = 0.8;
            int IntensityMax = 255;
            double Blue;
            double Green;
            double Red;
            double factor;
            if (Wavelength >= 380 && Wavelength <= 439)
            {
                Red = -(Wavelength - 440d) / (440d - 350d); Green = 0.0; Blue = 1.0;
            }
            else if (Wavelength >= 440 && Wavelength <= 489) { Red = 0.0; Green = (Wavelength - 440d) / (490d - 440d); Blue = 1.0; }
            else if (Wavelength >= 490 && Wavelength <= 509) { Red = 0.0; Green = 1.0; Blue = -(Wavelength - 510d) / (510d - 490d); }
            else if (Wavelength >= 510 && Wavelength <= 579) { Red = (Wavelength - 510d) / (580d - 510d); Green = 1.0; Blue = 0.0; }
            else if (Wavelength >= 580 && Wavelength <= 644) { Red = 1.0; Green = -(Wavelength - 645d) / (645d - 580d); Blue = 0.0; }
            else if (Wavelength >= 645 && Wavelength <= 780) { Red = 1.0; Green = 0.0; Blue = 0.0; }
            else
            {
                Red = 0.0; Green = 0.0; Blue = 0.0;
            }
            if (Wavelength >= 350 && Wavelength <= 419) { factor = 0.3 + 0.7 * (Wavelength - 380d) / (420d - 380d); }
            else if (Wavelength >= 420 && Wavelength <= 700) { factor = 1.0; }
            else if (Wavelength >= 701 && Wavelength <= 780) { factor = 0.3 + 0.7 * (780d - Wavelength) / (780d - 700d); }
            else
            {
                factor = 0.0;
            }
            int R = this.Adjust(Red, factor, IntensityMax, Gamma);
            int G = this.Adjust(Green, factor, IntensityMax, Gamma);
            int B = this.Adjust(Blue, factor, IntensityMax, Gamma);
            return Color.FromArgb(R, G, B);
        }
        private int Adjust(double Color, double Factor, int IntensityMax, double Gamma)
        {
            if (Color == 0.0) { return 0; }
            else
            {
                return (int)Math.Round(IntensityMax * Math.Pow(Color * Factor, Gamma));
            }
        }
    
        private  void getColorWaveArray()
        {
            int colorLength = 40;
            colorArray = new Color[colorLength];
            colorPosition = new float [colorLength];
            int arr;
            for(int i=0;i< colorLength; i++)
            {
                arr = 200 + i *20;
                colorArray [i]= WavelenghToRGB(arr);

                colorPosition[i] = i*1.0f /( colorLength-1);
            }
            
        }

        //public void addDarkLine(double wave)
        //{
        //    Graphics g=
        //}

    }
}
