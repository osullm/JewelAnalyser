using OmniDriver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JewelApp01;
using JewelApp01.Model;

namespace JewelApp01.Processer
{
    //声明一个添加谱线的委托
    public delegate void AddLinesHander(object wave, double[] spec, bool firstSeries,string name);
    public delegate void AddSpecLineHander(double[] spec, double[] wave,string showName);
    public delegate void RemoveSpecLineHander(int index);
    public delegate void setMinMaxWaveHander(double min, double max);
    public class ProcessSpec
    {
        private CCoWrapper spectrometor;
        private int numberOfSpectrometer;
        private int spectrometerIndex = 0;
        #region  委托
        public event AddLinesHander OnAddLines;
        public event AddSpecLineHander addSpecLine;
        public event RemoveSpecLineHander removeSpecLine;
        public event setMinMaxWaveHander setMinMaxWave;
        #endregion
        #region 外部可调用变量
        public int findPeakWidth { set; get; } = 10;
        public int findPeakSmoothWidth { set; get; } = 2;
        public int findPeakThreshold { get; set; } = 1;
        public int findPeakDerection { set; get; } = 0;

        public bool IsConn { set; get; }
        public List<SpectrumStruct> spectrumList { set; get; }
        public int JewID { set; get; }
        public int pixelNumber { set; get; }
        public int showStyle { set; get; }
        public const int SpectrumShowStyle = 11, SubDarkStyle = 33, ReflectanceShowStyle = 44;
        public double[] wavelengths { set; get; }
        //public double[] oneStepWave { get; set; }
        public double[] spectrum { set; get; }
        public double[] dark { set; get; }
        public double[] reference { set; get; }
        public double[] showY { set; get; }
        public double[] showX { set; get; }
        private int integrationTimeMS;
        public int IntegrationTimeMS
        {
            set
            {
                if(value !=integrationTimeMS)
                if (value >=8 && value <= 10000)
                {
                    spectrometor.setIntegrationTime(spectrometerIndex, value * 1000);
                    integrationTimeMS = value;
                }
                else
                {
                    MessageBox.Show("请输入正确值!");
                    spectrometor.setIntegrationTime(spectrometerIndex, 10 * 1000);
                    integrationTimeMS = 10;
                }
            }
            get { return integrationTimeMS; }
        }
        private int averageCounts;
        public int AverageCounts
        {
            set
            {
                if(value !=averageCounts )
                if (value >= 0 && value <= 1000)
                {
                    averageCounts = value;
                    spectrometor.setScansToAverage(spectrometerIndex, value);
                }
                else
                {
                    MessageBox.Show("请输入正确值！");
                    averageCounts = 5;
                    spectrometor.setScansToAverage(spectrometerIndex, 5);
                }
            }
            get
            {
                return this.averageCounts;
            }
        }
        private int boxcarWidth;
        public int BoxcarWidth
        {
            set
            {
                if (value!=boxcarWidth )
                if (value >= 0 && value <= 50)
                {
                    boxcarWidth = value;
                    spectrometor.setBoxcarWidth(spectrometerIndex, value);
                }
                else
                {
                    MessageBox.Show("请输入正确值！");
                    boxcarWidth = 3;
                    spectrometor.setBoxcarWidth(spectrometerIndex, 3);
                }
            }
            get
            {
                return this.boxcarWidth;
            }
        }
        private double[] showWavelength_MinMax;
        public double[] ShowWavelength_MinMax
        {
            set
            {
                if (value != ShowWavelength_MinMax)
                {
                    if (value[0] > 200 && value[1] <1000 && value[0] < value[1])
                    {
                        showWavelength_MinMax = value;
                        setMinMaxWave(value[0], value[1]);
                        
                        //oneStepWave =ProcessArray .getOneStepArrayDouble ()
                    }
                    else
                    {
                        showWavelength_MinMax = new double[] { 200, 1000 };
                        setMinMaxWave(200, 1000);
                    }
                }
            }
            get { return showWavelength_MinMax; }
        }


        private int  trigerState;
        public int TrigerState
        {
            set
            {
                if (trigerState != value)
                {
                    trigerState = value;

                    spectrometor.setExternalTriggerMode(spectrometerIndex, trigerState);

                }
            }
            get { return trigerState; }
        }


        public int cutlength = 16;


        #endregion

        public ProcessSpec()
        {
            spectrumList = new List<SpectrumStruct>();
            //spectrometor = new CCoWrapper();
        }

        public bool connectSpectrometer()
        {
            showStyle = SpectrumShowStyle;
            spectrometor = new CCoWrapper ();
            numberOfSpectrometer = spectrometor .openAllSpectrometers();
            IsConn = false;
            if (numberOfSpectrometer > 0)
            {
                IsConn = true;
                wavelengths = spectrometor.getWavelengths(0);
                loadjie();
               // spectrometor.setCorrectForElectricalDark(spectrometerIndex, 1);
                spectrometor.setCorrectForDetectorNonlinearity(spectrometerIndex, 1);
                //oneStepWave = ProcessArray.getOneStepArrayDouble(wavelengths);

                pixelNumber = wavelengths.Length;
                spectrum = spectrometor .getSpectrum(0);
                showY = spectrum;
                showX = wavelengths;
                ShowWavelength_MinMax = new double[] { wavelengths[0], wavelengths[wavelengths.Length - 1] };

                getSpectrum();
                return true;
            }
            else
            {
                return false;
            }
        }

        public  void getSpectrum()
        {
            try
            {
                spectrum = spectrometor.getSpectrum(0);
                int leng = spectrum.Length;
                for(int i=0; i< cutlength; i++)
                {
                    spectrum[i] = spectrum[cutlength];
                    spectrum[leng - 1 - i] = spectrum[leng - cutlength-1];
                }
                
                if (showStyle == SpectrumShowStyle)
                {
                    showY = spectrum;
                }
                else if (showStyle == ReflectanceShowStyle )
                {
                    for (int i = 0; i < pixelNumber; i++)
                    {
                            showY[i] = (spectrum[i] - dark[i]) * 100 / (reference[i] - dark[i]);
                    }

                }
                else if (showStyle == SubDarkStyle)
                {
                    for (int i = 0; i < pixelNumber; i++)
                    {
                        showY[i] = spectrum[i] - dark[i];
                    }
                }
                OnAddLines(showX, showY, false,"");
            }
            catch (Exception ex) {
                MessageBox.Show("获取光谱错误"+ex.Message );
            }
        }
        public void closeSpectrometers()
        {
            spectrometor.closeAllSpectrometers();
        }

        /// <summary>
        /// 保存谱图为暗值
        /// </summary>
        public void saveAsDark()
        {
            if(IsConn && this.spectrum!=null)
            {
                dark = new double[pixelNumber];
                spectrum.CopyTo(dark,0);
              
            }
            else
            {
                MessageBox.Show("请先连接光谱仪并采集谱图！");
            }
            
        }
        /// <summary>
        /// 保存谱图为参考
        /// </summary>
        public void saveAsReference()
        {
            if (IsConn && this.spectrum != null)
            {
                reference = new double[pixelNumber];
                spectrum.CopyTo(reference, 0);
            }
            else
            {
                MessageBox.Show("请先连接光谱仪并采集谱图！");
            }
            
        }


        /// <summary>
        /// 更改显示状态：原始光谱，扣暗光谱，反射光谱
        /// </summary>
        /// <param name="inShowStyle"></param>
        /// <returns></returns>
        public bool setSpecShowStyle(int inShowStyle)
        {

            switch (inShowStyle)
            {
                case SpectrumShowStyle:
                    this.showStyle = SpectrumShowStyle;
                    return true;

                case SubDarkStyle:
                    if (this.dark != null)
                    {
                        this.showStyle = SubDarkStyle;
                        return true;
                    }
                    else return false;

                    

                case ReflectanceShowStyle:
                    if (dark == null)
                    {
                        MessageBox.Show("请先存暗。");
                        return false;
                    }
                    else if (reference == null)
                    {
                        MessageBox.Show("请先参考。");
                        return false;
                    }
                    else
                    {
                        this.showStyle = inShowStyle;
                        return true;
                    }

                default:return false;
            }
           
            }
        
        public void recordSpec(int index)
        {
            SpectrumStruct spectrumClass = new SpectrumStruct();
            spectrumClass.SpectrumName = "谱图" + index;
            spectrumClass.SpectrumDate = DateTime.Now;
            spectrumClass.Wavelength = wavelengths;
            if (dark != null)
            {
                spectrumClass.Dark = dark;
            }
            else
                spectrumClass.Dark = new double[pixelNumber];
            if (this.reference != null)
            {
                spectrumClass.Reference = this.reference;
            }
            else
                spectrumClass.Reference = new double[pixelNumber];
            spectrumClass.Spectrum = this.spectrum;
            spectrumClass.ShowY = this.showY;
            spectrumList.Add(spectrumClass);
        }

        public void recordSpec(string name,double[] inWave,double[] inSpec)
        {
            SpectrumStruct spectrumClass = new SpectrumStruct();
            spectrumClass.SpectrumName = name;
            spectrumClass.Wavelength = inWave;
            spectrumClass.ShowY = inSpec;
            spectrumList.Add(spectrumClass);
        }


        public void removeRecordSpec(int index)
        {
            spectrumList.RemoveAt(index );
            //removeRecordSpec(index);
        }

        public void saveRevordSpec()
        {
            for(int i=0;i<spectrumList .Count;i++)
            {

            }
            //ProcessFile.saveTwoArray(DateTime.Now.ToFileTime().ToString(), one_nmWave, newy);

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                String path = folderDlg.SelectedPath;
                for (int i = 0; i < spectrumList.Count; i++)
                {
                    String name = path + "\\" + spectrumList[i].SpectrumName + ".txt";
                    FileStream fs = new FileStream(name, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs);
                    try
                    {
                        sw.WriteLine("Name:" + "\t" + spectrumList[i].SpectrumName);
                        sw.WriteLine("SaveTime:" + "\t" + spectrumList[i].SpectrumDate.ToString("yyyy-MM-dd hh:mm:ss"));
                        sw.WriteLine("Wave\tSpectrum");
                        for (int j = 0; j < spectrumList.ElementAt(i).Spectrum.Length; j++)
                        {
                            string wavelengthStr = spectrumList.ElementAt(i).Wavelength[j].ToString("f3");
                            string spectrumStr = spectrumList[i].ShowY   [j].ToString("f3");
                            sw.WriteLine(wavelengthStr +  "\t" + spectrumStr);
                        }
                        sw.Flush();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        sw.Close();
                        fs.Close();
                    }
                }
            }
            folderDlg.Dispose();
        }



        public void openSavedSpec()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] saveFaleNames=ofd.SafeFileNames;
                String[] names = ofd.FileNames;
                List<Double> arr1 = new List<Double>();
                List<Double> arr2 = new List<Double>();
                //List<Double> arr3 = new List<Double>();
                //List<Double> arr4 = new List<Double>();
                for (int i = 0; i < names.Length; i++)
                {
                    SpectrumStruct addedSpectrumStruct = new SpectrumStruct();
                    FileStream fs = new FileStream(names[i], FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    int count = 0;
                    try
                    {
                        string line = sr.ReadLine();
                        if (line != null)
                        {
                            String[] name = line.Split('\t');
                            addedSpectrumStruct.SpectrumName = name[1];
                        }

                        line = sr.ReadLine();
                        if (line != null)
                        {
                            String[] date = line.Split('\t');
                            addedSpectrumStruct.SpectrumDate = Convert.ToDateTime(date[1]);
                        }
                        line = sr.ReadLine();
                        line = sr.ReadLine();

                        while (line != null)
                        {
                            String[] a = line.Split('\t');
                            count++;
                            arr1.Add(double.Parse(a[0]));
                            arr2.Add(double.Parse(a[1]));
                            //arr3.Add(double.Parse(a[2]));
                            //arr4.Add(double.Parse(a[3]));
                            line = sr.ReadLine();
                        }
                        double[] bfwavelength = arr1.ToArray();
                        double[] bfspectrum = arr2.ToArray();
                        //double[] bfreference = arr3.ToArray();
                        //double[] bfspectrum = arr4.ToArray();
                        addedSpectrumStruct.Wavelength = bfwavelength;
                        //addedSpectrumStruct.Dark = bfdark;
                        //addedSpectrumStruct.Reference = bfreference;
                        addedSpectrumStruct.Spectrum = bfspectrum;
                        spectrumList.Add(addedSpectrumStruct);
                        saveFaleNames[i] = saveFaleNames[i].Remove(saveFaleNames[i].LastIndexOf("."));
                        addSpecLine(bfspectrum,bfwavelength, saveFaleNames[i]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        sr.Close();
                        fs.Close();
                    }
                }
            }
            ofd.Dispose();
        }

        /// <summary>
        /// 加载参数到记录文件。
        /// </summary>
        public  void  loadjie()
        {
            string pa = Environment.CurrentDirectory.ToString();
            String pathname = pa + "\\" + "log.jie";
            if (File.Exists(pathname))
            {
                FileStream fs = new FileStream(pathname, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                double[] minMaxWave = new double[2];
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    IntegrationTimeMS = int.Parse(buf[1]);
                }

                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    BoxcarWidth = int.Parse(buf[1]);
                }
                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    AverageCounts = int.Parse(buf[1]);
                }

                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    minMaxWave [0] = double.Parse(buf[1]);
                }
                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    minMaxWave [1] = double.Parse(buf[1]);
                }

                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    findPeakWidth= int.Parse(buf[1]);
                }
                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    findPeakSmoothWidth = int.Parse(buf[1]);
                }
                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    findPeakThreshold = int.Parse(buf[1]);
                }
                line = sr.ReadLine();
                if (line != null)
                {
                    String[] buf = line.Split('\t');
                    findPeakDerection = int.Parse(buf[1]);
                }
                ShowWavelength_MinMax = minMaxWave;
                sr.Close();
                fs.Close();
            }
        }
        /// <summary>
        /// 保存记录文件
        /// </summary>
        public  void savejjie()
        {
            string pa = Environment.CurrentDirectory.ToString();
            String name = pa + "\\" + "log.jie";

            FileStream fs = new FileStream(name, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine("积分时间：\t" + integrationTimeMS.ToString());
                sw.WriteLine("平滑宽度：\t" + boxcarWidth.ToString());
                sw.WriteLine("平均次数：\t" + averageCounts.ToString());
                sw.WriteLine("显示最小波长：\t" + this.showWavelength_MinMax[0] .ToString());
                sw.WriteLine("显示最大波长：\t" + this.showWavelength_MinMax[1].ToString());

                sw.WriteLine("寻峰宽度：\t" + findPeakWidth.ToString());
                sw.WriteLine("寻峰平滑宽度：\t" + findPeakWidth .ToString());
                sw.WriteLine("寻峰阈值：\t" + findPeakThreshold.ToString());
                sw.WriteLine("寻峰朝向：\t" + findPeakDerection.ToString());

                sw.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        public void addSpectrumList(List<SpectrumStruct> insertSpectrumList)
        {
            if(insertSpectrumList!=null)
            {
                spectrumList.AddRange(insertSpectrumList);
                for (int i = 0; i < insertSpectrumList.Count; i++)
                {
                    addSpecLine(insertSpectrumList[i].ShowY, insertSpectrumList[i].Wavelength, insertSpectrumList[i].SpectrumName);
                }
            }
           
        }

        public void softTrig()
        {
            spectrometor.sendSimulatedTriggerSignal(spectrometerIndex);
        }
    }
}
