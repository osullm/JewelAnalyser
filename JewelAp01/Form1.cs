using JewelApp01.Model;
using JewelApp01.Processer;
using JewelApp01.Product;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TeeChart;

namespace JewelApp01
{
    public partial class Form1 : Form
    {
        public ProcessSpec processSpec { get; set; }
        public Thread getSpectrumThread;
        public static Boolean start = false;
        public bool showCursor;
        private int boldLineWidth = 1;
        ColorListClass colorList = new ColorListClass();
        public ChangeLineIndexEventHander changeLineEvent;
        public Point mouseD0ownPoint=new Point ();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Chart_spec.Series(0).Clear();
            Chart_spec.Series(1).Clear();
            
            Chart_spec.Series(1).VerticalAxisCustom = 0;
            processSpec = new ProcessSpec();
            processSpec.OnAddLines += chart_Spectrum_addLine;
            processSpec.setMinMaxWave +=resetChartMinMax;
            processSpec.addSpecLine += addSpecSeries;
            
            fittingControl1.stopGetSpec += StopThread;
            fittingControl1.selectTablePage2 += selectTablePage;
            fittingControl1.setRemarks += setRemarks;
            fittingControl1.addSpecLine += addSpecSeries;
            fittingControl1.setSignEvent += addSignFittingChart;
            string str = "select max(ID) from JewDataTable  ";
            string obj = SqliteHelper.ExecuteScalar(str).ToString();
            //int id = (int.Parse(obj) + 1);
            processSpec.JewID = (int.Parse(obj) + 1);
            addJewDataControl1.processSpec =processSpec ;
            addJewDataControl1.loadCreatorClass();
            fittingControl1.processSpec = processSpec;


            bool connectState=processSpec.connectSpectrometer();
            if (connectState)
            {
                settoolStripStatusLabel1Text("成功连接光谱仪");
            }
            else
            {
                settoolStripStatusLabel1Text("未发现光谱仪");
            }

            int gridindex = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[gridindex].Cells[0].Value = true;
            this.dataGridView1.Rows[gridindex].Cells[1].Style.BackColor = Color.Red;
            this.dataGridView1.Rows[gridindex].Cells[2].Value = "当前谱图";
            this.dataGridView1.Rows[gridindex].Cells[2].ReadOnly = true;
            if (processSpec.IsConn)
            {
                start = true;
                getSpectrumThread = new Thread(new ThreadStart(run));
                getSpectrumThread.Start();
                getSpectrumThread.IsBackground = true;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            Chart_spec.Tools.Items[0].Active = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (processSpec.IsConn && start == false)
            {

                if (getSpectrumThread != null)
                {
                    start = true;
                    getSpectrumThread = new Thread(new ThreadStart(run));
                    getSpectrumThread.Start();
                }
            }
        }
        private void StopThread()
        {
            start = false;
        }

        private void selectTablePage(int index)
        {
            this.tabControl2.SelectedIndex = index;
        }
        private void run()
        {
            while (start)
            {
                if (processSpec.IsConn)
                {
                    processSpec.getSpectrum();
                    
                }

            }
            StopThread();
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            start = false;
        }

        private void btn_zoomOut_Click(object sender, EventArgs e)
        {
            if (processSpec.showStyle == ProcessSpec.SpectrumShowStyle)
            {
                Chart_spec.Axis.Left.Automatic = false;
                if(Chart_spec.Axis .Left .Minimum <66000)
                {
                    Chart_spec.Axis.Left.Maximum = 66000;
                    Chart_spec.Axis.Left.Minimum = 0;
                }
                else
                {
                    Chart_spec.Axis.Left.Minimum = 0;
                    Chart_spec.Axis.Left.Maximum = 66000;
                }
                
            }
            else if (processSpec.showStyle == ProcessSpec.ReflectanceShowStyle)
            {
                Chart_spec.Axis.Left.Automatic = false;
                if (Chart_spec.Axis.Left.Minimum < 120)
                {
                    Chart_spec.Axis.Left.Maximum = 120;
                    Chart_spec.Axis.Left.Minimum = 0;
                }
                else
                {
                    Chart_spec.Axis.Left.Minimum = 0;
                    Chart_spec.Axis.Left.Maximum = 120;
                }
            }
            else if (processSpec.showStyle == ProcessSpec.SubDarkStyle)
            {
                Chart_spec.Axis.Left.Automatic = false;
                if (Chart_spec.Axis.Left.Minimum < 66000)
                {
                    Chart_spec.Axis.Left.Maximum = 66000;
                    Chart_spec.Axis.Left.Minimum = 0;
                }
                else
                {
                    Chart_spec.Axis.Left.Maximum = 0;
                    Chart_spec.Axis.Left.Minimum = 66000;
                }
            }


        }
        private void btn_zoomIn_Click(object sender, EventArgs e)
        {
            
            if (processSpec.IsConn)
            {
                if (double.IsNegativeInfinity(Chart_spec.Axis.Left.Minimum) && double.IsPositiveInfinity(Chart_spec.Axis.Left.Maximum))
                    return;


                int minIndex = ProcessArray.getCursorIndex(Chart_spec.Axis.Bottom.Minimum, processSpec.wavelengths);
                int maxIndex = ProcessArray.getCursorIndex(Chart_spec.Axis.Bottom.Maximum, processSpec.wavelengths);
                double maxValue = processSpec.showY[maxIndex];
                double minValue = processSpec.showY[minIndex];
                for (int i = minIndex; i < maxIndex; i++)
                {

                    if (processSpec.showY[i] < minValue)
                        minValue = processSpec.showY[i];
                    if (processSpec.showY[i] > maxValue)
                        maxValue = processSpec.showY[i];
                }

                Chart_spec.Axis.Left.Automatic = false;
                double max= maxValue + (maxValue - minValue) * 0.1;
                double min= minValue - (maxValue - minValue) * 0.1;

                if(max< Chart_spec.Axis.Left.Minimum)
                {
                    Chart_spec.Axis.Left.Minimum = min;
                    Chart_spec.Axis.Left.Maximum = max;
                    
                }
                else
                {
                    Chart_spec.Axis.Left.Maximum = max;
                    Chart_spec.Axis.Left.Minimum = min;
                }
                   
            }
            

        }
        private void btn_removeRecord_Click(object sender, EventArgs e)
        {
            int selectedRowsCounts = dataGridView1.SelectedCells.Count;
            foreach (DataGridViewCell dgvRow in dataGridView1.SelectedCells)
            {
                int index = dgvRow.RowIndex;
                if (index > 0)
                {
                    Chart_spec.RemoveSeries(index+1);

                    processSpec.removeRecordSpec(index - 1);
                    dataGridView1.Rows.Remove(dgvRow.OwningRow);
                }
            }

        }
        private void btn_record_Click(object sender, EventArgs e)
        {
            if (processSpec.IsConn)
            {
                int index = Chart_spec.AddSeries(ESeriesClass.scFastLine);
                Color co = colorList.getNextColor();
                Chart_spec.Series(index).Color = (uint)ColorTranslator.ToWin32(co);
                Chart_spec.Series(index).asFastLine.LinePen.Width = boldLineWidth;
                Chart_spec.Series(index).AddArray(processSpec.pixelNumber, processSpec.showY, processSpec.showX);

                processSpec.recordSpec(index);

                
                int gridindex = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[gridindex].Cells[0].Value = true;
                this.dataGridView1.Rows[gridindex].Cells[1].Style.BackColor = co;
                this.dataGridView1.Rows[gridindex].Cells[1].Style.SelectionForeColor = co;
                this.dataGridView1.Rows[gridindex].Cells[2].Value = "谱图" + index;

            }

        }

        private void addSpecSeries(double[] bfspectrum, double[] bfwavelength,  string showName="")
        {
            if(showName=="")
            {
                showName = "谱图" + (Chart_spec.SeriesCount - 1);
            }
            processSpec.recordSpec(showName, bfwavelength, bfspectrum);

            ESeriesClass series = new ESeriesClass();
            int index = Chart_spec.AddSeries(series);
            Color co = colorList.getNextColor();
            Chart_spec.Series(index).Color = (uint)ColorTranslator.ToWin32(co);
            Chart_spec.Series(index).asFastLine.LinePen.Width = boldLineWidth;
            Chart_spec.Series(index).AddArray(bfwavelength.Length, bfspectrum, bfwavelength);
            int gridindex = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[gridindex].Cells[0].Value = true;
            this.dataGridView1.Rows[gridindex].Cells[1].Style.BackColor = co;
            this.dataGridView1.Rows[gridindex].Cells[1].Style.SelectionForeColor = co;
            this.dataGridView1.Rows[gridindex].Cells[2].Value = showName;
        }
        private void btn_saveDark_Click(object sender, EventArgs e)
        {

            processSpec.saveAsDark();
            if (processSpec.dark != null && processSpec.reference != null)
            {
                btn_Reflect.PerformClick();
            }
        }
        private void btn_saveReference_Click(object sender, EventArgs e)
        {
            processSpec.saveAsReference();
            if (processSpec.dark != null && processSpec.reference != null)
            {
                btn_Reflect.PerformClick();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int columnIndex = e.ColumnIndex;
                if (columnIndex == 0)
                {
                    int rowIndex = e.RowIndex;
                    Boolean value = Boolean.Parse(this.dataGridView1.Rows[rowIndex].Cells[columnIndex].EditedFormattedValue.ToString());
                    if (value)
                    {
                        if(rowIndex ==0)
                        { Chart_spec.Series(rowIndex ).Active = true; }
                        else
                        Chart_spec.Series(rowIndex+1).Active = true;
                    }
                    else
                    {
                        if (rowIndex == 0)
                        { Chart_spec.Series(rowIndex).Active = false; }
                        else
                        Chart_spec.Series(rowIndex+1).Active = false;
                    }
                }
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 2)
            {
                if (row > 0&& processSpec.spectrumList.Count > 0)
                {
                    string changedName = this.dataGridView1.Rows[row].Cells[column].EditedFormattedValue.ToString();
                    //MessageBox.Show("行：" + row + "--spectrumList .Count:" + spectrumList.Count);
                    SpectrumStruct changedspectrum = processSpec.spectrumList[row - 1];
                    changedspectrum.SpectrumName = changedName;
                    processSpec.spectrumList[row - 1] = changedspectrum;
                }
            }
        }
        private void axTChart1_OnCursorToolChange(object sender, AxTeeChart.ITChartEvents_OnCursorToolChangeEvent e)
        {
            double Xvalue;
            Xvalue = Chart_spec.Tools.Items[0].asTeeCursor.XVal;
            nud_xAxis.Value = Decimal.Parse(Xvalue.ToString());
        }

        private void btn_spec_Click(object sender, EventArgs e)
        {
            if (processSpec.setSpecShowStyle(ProcessSpec.SpectrumShowStyle))
            {
                Chart_spec.Axis.Left.Title.Caption = "counts";
                Chart_spec.Axis.Left.Automatic = false;
                if(Chart_spec.Axis.Left.Minimum <65000)
                {
                    Chart_spec.Axis.Left.Maximum = 65000;
                    Chart_spec.Axis.Left.Minimum = 0;
                }
                else
                {
                    Chart_spec.Axis.Left.Minimum = 0;
                    Chart_spec.Axis.Left.Maximum = 65000;
                }
            }
        }

        private void btn_Reflect_Click(object sender, EventArgs e)
        {
            if (processSpec.setSpecShowStyle(ProcessSpec.ReflectanceShowStyle))
            {
                Chart_spec.Axis.Left.Title.Caption = "反射率（%）";
                Chart_spec.Axis.Left.Automatic = false;
                if(Chart_spec.Axis.Left.Minimum<120)
                {
                    Chart_spec.Axis.Left.Maximum = 120;
                    Chart_spec.Axis.Left.Minimum = 0;
                }
                else
                {
                    Chart_spec.Axis.Left.Minimum = 0;
                    Chart_spec.Axis.Left.Maximum = 120;
                }
            }
        }
        public void settoolStripStatusLabel1Text(string str)
        {
            this.toolStripStatusLabel1.Text = str;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex != 1)
                return;
            ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();
            Color c;
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                c = cd.Color;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = c;
                Chart_spec.Series(e.RowIndex+1).Color = (uint)ColorTranslator.ToWin32(c);
            }
        }
        private void 导出当前数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int length = (int)processSpec.ShowWavelength_MinMax[1] - (int)processSpec.ShowWavelength_MinMax[0] + 1;
            if (length <= 0)
                return;
            double[] one_nmWave = new double[length];
            for (int i = 0; i < one_nmWave.Length; i++)
            {
                one_nmWave[i] = i + (int)processSpec.ShowWavelength_MinMax[0];
            }
            double[] newy = ProcessArray.FixArrayY(one_nmWave, processSpec.showX, processSpec.showY);

            ProcessFile.saveCurrentTwoArray(DateTime.Now.ToFileTime().ToString (), one_nmWave, newy);
        }
        /// <summary>
        /// 添加谱线，当传入值spec为空时，清空除了第一条线之外的其他谱线。
        /// </summary>
        /// <param name="wave"></param>
        /// <param name="spec"></param>
        private void chart_fitting_addLine(object wave, double[] spec, bool newSeries,string name)
        {
            if (spec == null)
            {
                for (int i = Chart_fitting.SeriesCount-1; i >1; i--)
                {
                    Chart_fitting.RemoveSeries(i);
                }
            }
            else
            {
                if (newSeries)
                {
                    ESeriesClass series = new ESeriesClass();
                    int index = Chart_fitting.AddSeries(series);
                    Chart_fitting.Series(index).Title = name;
                    Chart_fitting.Series(index).AddArray(spec.Length, spec, wave);
                    Chart_fitting.Series(index).Color = (uint)ColorTranslator.ToWin32(Color.Blue);
                }
                else
                {
                    Chart_fitting.Series(0).AddArray(spec.Length, spec,wave );
                }
            }
        }
        private void chart_Spectrum_addLine(object wave, double[] spec, bool newSeries,string name)
        {

            if (newSeries)
            {
                ESeriesClass series = new ESeriesClass();
                
                int index = Chart_spec.AddSeries(series);
                Chart_fitting.Series(index).Title  = name;
                Chart_fitting.Series(index).AddArray(spec.Length, spec, wave);
            }
            else
            {
                Chart_spec.Series(0).AddArray(spec.Length, spec, wave);
            }
            
        }

        private void resetChartMinMax(double min,double max)
        {
            if(max< Chart_spec.Axis.Bottom.Minimum )
            {
                Chart_spec.Axis.Bottom.Minimum  = min;
                Chart_spec.Axis.Bottom.Maximum = max;
            }
            else
            {
                Chart_spec.Axis.Bottom.Maximum = max;
                Chart_spec.Axis.Bottom.Minimum = min;
            }
               
        }
        private void 数据库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SqlData sqldata = new SqlData();
            sqldata.addSpecLine += addSpecSeries;
            sqldata.Show();

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            start = false;
            if (MessageBox.Show("确定退出?", "退出", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                btn_start  .PerformClick ();
                e.Cancel = true;
                return;
            }

            if (processSpec.IsConn )
                processSpec.savejjie();
        }

        private void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm setForm = new SettingForm();
            setForm.processSpec = processSpec;
            setForm.ShowDialog();
        }

        private void cbx_showCursor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_showCursor.Checked == true)
            {
                Chart_spec.Tools.Items[0].Active = true;
                showCursor = true;

                double yValue = (double)nud_xAxis.Value;

            }
            else
            {
                Chart_spec.Tools.Items[0].Active = false;
                showCursor = false;
            }
        }

        private void nud_xAxis_ValueChanged(object sender, EventArgs e)
        {
            double x = Double.Parse(nud_xAxis.Value.ToString());
            Chart_spec.Tools.Items[0].asTeeCursor.XVal = x;
        }

        private void 保存记录的谱图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessFile.saveListTwoArray(processSpec.spectrumList);
        }

        private void btn_findPeak_Click(object sender, EventArgs e)
        {
            if(!processSpec.IsConn )
            return;
            double[] showY = new double[processSpec.showY.Length];
            Array.Copy(processSpec.showY, showY, showY.Length);
            List<int> peaks1=new List<int> (), peaks2=new List<int> ();
            if (processSpec.findPeakDerection == 0)
            {
                double[] backShowY = new double[processSpec.showY.Length];
                for (int i = 0; i < processSpec.showY.Length; i++)
                {
                    backShowY[i] = (-1) * processSpec.showY[i];
                }
                peaks2 = ProcessArray.findPeaks(backShowY, processSpec.findPeakWidth, processSpec.findPeakSmoothWidth, processSpec.findPeakThreshold);
            }
            else if (processSpec.findPeakDerection == 1)
            {
                peaks1 = ProcessArray.findPeaks(processSpec.showY, processSpec.findPeakWidth, processSpec.findPeakSmoothWidth, processSpec.findPeakThreshold);
            }
            else if (processSpec.findPeakDerection == 2)
            {
                peaks1 = ProcessArray.findPeaks(processSpec.showY, processSpec.findPeakWidth, processSpec.findPeakSmoothWidth, processSpec.findPeakThreshold);
                double[] backShowY = new double[processSpec.showY.Length];
                for (int i = 0; i < processSpec.showY.Length; i++)
                {
                    backShowY[i] = (-1) * processSpec.showY[i];
                }
                peaks2 = ProcessArray.findPeaks(backShowY, processSpec.findPeakWidth, processSpec.findPeakSmoothWidth, processSpec.findPeakThreshold);
            }
            peaks1.AddRange(peaks2);
            peaks1.Sort();
            double[] peakX = new double[peaks1.Count];
            double[] peakY = new double[peaks1.Count];

            for (int i=0;i<peaks1 .Count;i++)
            {

                peakX[i] = processSpec.wavelengths[peaks1[i]];
                peakY[i] = showY[peaks1[i]];
            }
            if (peakX.Length > 0)
                Chart_spec.Series(1).AddArray(peakX.Length, peakY, peakX);
            else
                Chart_spec.Series(1).Clear();
        }
        private void 寻峰设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_findPeakSetting peakform = new Form_findPeakSetting();
            peakform.processSpec = processSpec;
            peakform.Show();
        }
        private void 打开两列数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processSpec.addSpectrumList(ProcessFile.loadListTwoArray());
        }
        public void setRemarks(string text)
        {
            this.Chart_fitting.Tools.Items[0].asAnnotation.Text = text;
        }

        private void 色带ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(色带ToolStripMenuItem .Checked )
            {
                tableLayoutPanel1.RowStyles[2].Height=60;
            }
            else
            {
                tableLayoutPanel1.RowStyles[2].Height = 0;
            }
        }
        private void tsMenu_colorBar_Click(object sender, EventArgs e)
        {
            if(tsMenu_colorBar .Checked )
            {
                tableLayoutPanel1.RowStyles[2].Height = 60;
            }
            else
            {
                tableLayoutPanel1.RowStyles[2].Height = 0;
            }
        }
        private void Chart_spec_OnMouseUp(object sender, AxTeeChart.ITChartEvents_OnMouseUpEvent e)
        {
            if(MousePosition==mouseD0ownPoint )
            {
                if (e.button == EMouseButton.mbRight)
                {
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double Xva = Chart_spec.Series(0).MouseValues.X;
            double Yva = Chart_spec.MousePosition.Y;
            if (Chart_spec.Series(0).XValues.Count <1)
                return;
            double xval=Chart_spec.Tools.Items[3].asTeeCursor.XVal;
            uint color = Chart_spec.Series(1).Color;
            int index = 0;
            double minvalue =Math .Abs ( Chart_spec.Series(0).XValues.Value[0] - xval);
            for (int i=0;i< Chart_spec.Series(0).XValues.Count;i++)
            {
                if(Math.Abs(Chart_spec.Series(0).XValues.Value[i] - xval)<minvalue )
                {
                    minvalue = Math.Abs(Chart_spec.Series(0).XValues.Value[i] - xval);
                    index = i;
                }
            }
            double yval = Chart_spec.Series(0).YValues.Value[index];
             Chart_spec.Series(1).AddXY(xval ,yval ,xval .ToString ("f3"),color);
            colorBar1.drawLine(xval);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Chart_spec.Series(1).XValues.Count < 1)
                return;
            double xval = Chart_spec.Tools.Items[2].asTeeCursor.XVal;
            //uint color = Chart_spec.Series(1).Color;
            int index = 0;
            double minvalue = Math.Abs(Chart_spec.Series(1).XValues.Value[0] - xval);
            for (int i = 0; i < Chart_spec.Series(1).XValues.Count; i++)
            {
                if (Math.Abs(Chart_spec.Series(1).XValues.Value[i] - xval) < minvalue)
                {
                    minvalue = Math.Abs(Chart_spec.Series(1).XValues.Value[i] - xval);
                    index = i;
                }
            }
            if(minvalue <30)
            {
                colorBar1.removeLine(Chart_spec.Series(1).XValues.Value[index]);
                Chart_spec.Series(1).Delete(index);
            }
        }

        private void 清除峰位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Chart_spec.Series(1).Active && Chart_spec.Series(1).Count >0)
            Chart_spec.Series(1).Clear();
            colorBar1.clearLine();
        }

        private void btn_zoomIn2_Click(object sender, EventArgs e)
        {
            Chart_spec.Axis.Left.Automatic = true;
        }
        List<ESeriesClass> signSeriesList = new List<ESeriesClass>();
        private void addSignFittingChart(int[] bufwave,double[] bufspec,double [] realSign,double[] unrealSign)
        {
            for (int i = Chart_fitting.SeriesCount-1; i > 2; i--)
            {
                Chart_fitting.RemoveSeries(i);
            }
            Chart_fitting.Series(1).Clear ();

            if (realSign.Length == 0 && unrealSign.Length == 0)
                return;

            double[] markx = new double[realSign.Length + unrealSign.Length];
            double[] marky = new double[realSign.Length + unrealSign.Length];
            for (int i=0;i<realSign .Length;i++)
            {
                int waveindex = ProcessArray.getCursorIndex(realSign[i], bufwave);
                double[] newserArrayY = new double[] { 0, bufspec [waveindex ] };
                double[] newserArrayX = new double[] { realSign[i], realSign[i] };
                int index=Chart_fitting.AddSeries(ESeriesClass.scFastLine);
                Chart_fitting.Series(index).AddArray(2, newserArrayY, newserArrayX);
                Chart_fitting.Series(index).asFastLine .LinePen.Width = 2;
                Chart_fitting.Series(index).asFastLine.LinePen.Color = (uint)ColorTranslator.ToWin32(Color.Green);

                markx[i] = realSign[i];
                marky[i] = bufspec[waveindex];
            }
            for(int i=0;i<unrealSign .Length;i++)
            {
                int waveindex = ProcessArray.getCursorIndex(unrealSign[i], bufwave);
                double[] newserArrayY = new double[] { 0, bufspec[waveindex] };
                double[] newserArrayX = new double[] { unrealSign[i], unrealSign[i] };
                int index = Chart_fitting.AddSeries(ESeriesClass.scFastLine);
                Chart_fitting.Series(index).AddArray(2, newserArrayY, newserArrayX);
                Chart_fitting.Series(index).asFastLine.LinePen.Width = 2;
                Chart_fitting.Series(index).asFastLine.LinePen.Color = (uint)ColorTranslator.ToWin32(Color.Red);

                markx[i + realSign.Length] = unrealSign[i];
                marky[i + realSign.Length] = bufspec[waveindex];

            }

            int serindex = 1;
            Chart_fitting.Series(serindex).AddArray(marky .Length , marky, markx);
            Chart_fitting.Series(serindex).asPoint.Pointer.Visible = false;

            Chart_fitting.Series(serindex).Marks.Style = EMarkStyle.smsXValue;
            Chart_fitting.Series(serindex).Marks.Symbol.Visible = false;
             Chart_fitting.Series(serindex).Marks.Show()  ;
            

        }
        private void 软触发ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processSpec.softTrig();
        }
        private void 粗曲线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( 粗曲线ToolStripMenuItem.Checked )
            {
                粗曲线ToolStripMenuItem.Checked = false;
                boldLineWidth = 1;
                for (int i = 0; i < Chart_spec.SeriesCount; i++)
                {
                    if (i == 1)
                        continue;
                    Chart_spec.Series(i).asFastLine.LinePen.Width = boldLineWidth;
                }


            }
            else
            {
                粗曲线ToolStripMenuItem.Checked = true;
                boldLineWidth = 2;
                for (int i = 0; i < Chart_spec.SeriesCount; i++)
                {
                    if (i == 1)
                        continue;
                    Chart_spec.Series(i).asFastLine.LinePen.Width = boldLineWidth;
                }

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dataGridView1 .CurrentCell.ColumnIndex>1)
            {
                
                int index = dataGridView1.CurrentCell.RowIndex;
                if(changeLineEvent!=null)
                {
                    changeLineEvent(index);
                }
                    
                if (index >= 1)
                {
                    index++;
                }

                for (int i = 0; i < Chart_spec.SeriesCount; i++)
                {
                    if(i==1)
                    {
                        continue;
                    }

                    if(i==index)
                    {
                        Chart_spec.Series(i).asFastLine .LinePen.Width = boldLineWidth + 2;
                    }
                    else
                    {
                        if (Chart_spec.Series(i).asFastLine.LinePen.Width != boldLineWidth)
                            Chart_spec.Series(i).asFastLine.LinePen.Width = boldLineWidth;
                    }
                }
            }
        }

        private void Chart_spec_OnMouseDown(object sender, AxTeeChart.ITChartEvents_OnMouseDownEvent e)
        {
            mouseD0ownPoint = MousePosition;

        }

        private void 移动曲线ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LineMover linemover = new LineMover();
            changeLineEvent += linemover.setLineIndex;
            linemover.chart = Chart_spec;
            linemover.ChartIndex = dataGridView1.CurrentRow.Index;
            linemover.Show();
        }
    }
}
