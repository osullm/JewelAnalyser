using JewelApp01.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelApp01.Processer
{
    class ProcessFile
    {
        public static void saveCurrentTwoArray(string fname,double[] Array1,double[] Array2)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                String path = folderDlg.SelectedPath;

                String name = path + "\\" + fname + ".txt";
                FileStream fs = new FileStream(name, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                try
                {
                    sw.WriteLine("波长" + "\t" + "值");
                    for (int j = 0; j < Array1.Length; j++)
                    {
                        string wave = Array1[j].ToString("f3");
                        string spec = Array2[j].ToString("f3");
                        sw.WriteLine(wave + "\t" + spec);
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

            folderDlg.Dispose();
        }

        //public List<SpectrumStruct> openTwoArraySpec()
        //{
        //    List<SpectrumStruct> spectrumList = new List<SpectrumStruct>();

        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "(*.txt)|*.txt|(*.*)|*.*";
        //    ofd.RestoreDirectory = true;
        //    ofd.Multiselect = true;

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        string[] saveFaleNames = ofd.SafeFileNames;
        //        String[] names = ofd.FileNames;
        //        List<Double> arr1 = new List<Double>();
        //        List<Double> arr2 = new List<Double>();
        //        //List<Double> arr3 = new List<Double>();
        //        //List<Double> arr4 = new List<Double>();


        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            SpectrumStruct addedSpectrumStruct = new SpectrumStruct();

        //            FileStream fs = new FileStream(names[i], FileMode.Open);
        //            StreamReader sr = new StreamReader(fs);
        //            int count = 0;
        //            try
        //            {
        //                arr1.Clear();
        //                arr2.Clear();
        //                string line = sr.ReadLine();
        //                line = sr.ReadLine();
        //                while (line != null)
        //                {
        //                    String[] a = line.Split('\t');
        //                    if (a.Length == 2)
        //                    {
        //                        count++;
        //                        arr1.Add(double.Parse(a[0]));
        //                        arr2.Add(double.Parse(a[1]));
        //                    }
        //                    line = sr.ReadLine();
        //                }
        //                double[] bfwavelength = arr1.ToArray();
        //                double[] bfspectrum = arr2.ToArray();
        //                addedSpectrumStruct.Wavelength = bfwavelength;
        //                addedSpectrumStruct.ShowY  = bfspectrum;
        //                spectrumList.Add(addedSpectrumStruct);
        //                saveFaleNames[i] = saveFaleNames[i].Remove(saveFaleNames[i].LastIndexOf("."));
        //                //(bfspectrum, bfwavelength, saveFaleNames[i]);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message.ToString());
        //            }
        //            finally
        //            {
        //                sr.Close();
        //                fs.Close();
        //            }
        //        }
        //        if (spectrumList.Count > 0)
        //            return spectrumList;
        //        else return null;
        //    }
        //    else
        //        return null;
        //    //ofd.Dispose();
        //}

        public static void saveListTwoArray(List<SpectrumStruct> spectrumList)
        {
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
                        sw.WriteLine("波长" + "\t" + "值");
                        //sw.WriteLine("SaveTime:" + "\t" + spectrumList[i].SpectrumDate.ToString("yyyy-MM-dd hh:mm:ss"));
                        //sw.WriteLine("Wave\tSpectrum");
                        for (int j = 0; j < spectrumList.ElementAt(i).Spectrum.Length; j++)
                        {
                            string wavelengthStr = spectrumList.ElementAt(i).Wavelength[j].ToString("f3");
                            string spectrumStr = spectrumList[i].ShowY[j].ToString("f3");
                            sw.WriteLine(wavelengthStr + "\t" + spectrumStr);
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

        public static List<SpectrumStruct> loadListTwoArray()
        {
            List<SpectrumStruct> spectrumList = new List<SpectrumStruct>();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] saveFaleNames = ofd.SafeFileNames;
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
                        //if (line != null)
                        //{
                        //    String[] name = line.Split('\t');
                        //    addedSpectrumStruct.SpectrumName = name[1];
                        //}

                        //line = sr.ReadLine();
                        //if (line != null)
                        //{
                        //    String[] date = line.Split('\t');
                        //    addedSpectrumStruct.SpectrumDate = Convert.ToDateTime(date[1]);
                        //}
                        //line = sr.ReadLine();
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
                        addedSpectrumStruct.SpectrumName = saveFaleNames[i].Remove(saveFaleNames[i].LastIndexOf(".")); ;
                        //double[] bfreference = arr3.ToArray();
                        //double[] bfspectrum = arr4.ToArray();
                        addedSpectrumStruct.Wavelength = bfwavelength;
                        //addedSpectrumStruct.Dark = bfdark;
                        //addedSpectrumStruct.Reference = bfreference;
                        addedSpectrumStruct.ShowY  = bfspectrum;
                        spectrumList.Add(addedSpectrumStruct);
                        //saveFaleNames[i] = saveFaleNames[i].Remove(saveFaleNames[i].LastIndexOf("."));
                       // addSpecLine(bfspectrum, bfwavelength, saveFaleNames[i]);
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
                if (spectrumList.Count > 0)
                    return spectrumList;
                else return null;
            }
            else
            {
                return null;
            }
            ////ofd.Dispose();
        }
    }
}
