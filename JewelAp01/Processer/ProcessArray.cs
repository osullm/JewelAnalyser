//using DoSmoothPro;
//using MathWorks.MATLAB.NET.Arrays;
using System;
using System.Collections.Generic;

namespace JewelApp01.Processer
{
    public static class ProcessArray
    {
        /// <summary>
        /// 插值法，根据新给的X坐标，从原有的X-Y坐标中算出新Y坐标，前后补0；
        /// </summary>
        /// <param name="newX">新给的X坐标</param>
        /// <param name="originalX">原来的X坐标</param>
        /// <param name="originalY">原来的Y坐标</param>
        /// <returns></returns>
        public static double[] FixArrayY(double[] newX, double[] originalX, double[] originalY)
        {
            double[] numArray = new double[newX.Length];
            int startIndex = 0;
            for (int i = 0; i < newX.Length; i++)
            {
                if (newX[i] <= originalX[0])
                {
                    numArray[i] = 0.0;
                }
                else if (newX[i] >= originalX[originalX.Length - 1])
                {
                    numArray[i] = 0.0;
                }
                else
                {
                    for (int j = startIndex ; j < originalX.Length; j++)
                    {
                        if ((originalX[j] <= newX[i]) && (originalX[j + 1] >= newX[i]))
                        {
                            numArray[i] = (((originalY[j + 1] - originalY[j])*(newX[i] - originalX[j])) / (originalX[j + 1] - originalX[j])) + originalY[j];
                            startIndex = j;
                            break;
                        }
                    }
                }
            }
            return numArray;
        }

        /// <summary>
        /// 插值法，根据新给的X坐标，从原有的X-Y坐标中算出新Y坐标，前后补0；
        /// </summary>
        /// <param name="newX">新给的X坐标</param>
        /// <param name="originalX">原来的X坐标</param>
        /// <param name="originalY">原来的Y坐标</param>
        /// <returns></returns>
        public static double[] FixArrayY(int[] newX, double[] originalX, double[] originalY)
        {
            double[] numArray = new double[newX.Length];
            int startIndex = 0;
            for (int i = 0; i < newX.Length; i++)
            {
                if (newX[i] <= originalX[0])
                {
                    numArray[i] = 0.0;
                }
                else if (newX[i] >= originalX[originalX.Length - 1])
                {
                    numArray[i] = 0.0;
                }
                else
                {
                    for (int j = startIndex; j < originalX.Length; j++)
                    {
                        if ((originalX[j] <= newX[i]) && (originalX[j + 1] >= newX[i]))
                        {
                            numArray[i] = (((originalY[j + 1] - originalY[j]) * (newX[i] - originalX[j])) / (originalX[j + 1] - originalX[j])) + originalY[j];
                            startIndex = j;
                            break;
                        }
                    }
                }
            }
            return numArray;
        }

        /// <summary>
        /// 插值法，根据新给的X坐标，从原有的X-Y坐标中算出新Y坐标，前后补第一个值和最后一个值；
        /// </summary>
        /// <param name="newX">新给的X坐标</param>
        /// <param name="originalX">原来的X坐标</param>
        /// <param name="originalY">原来的Y坐标</param>
        /// <returns></returns>
        public static double[] FixArrayY_FirstLast(double[] newX, double[] originalX, double[] originalY)
        {
            double[] numArray = new double[newX.Length];

            int startIndex = 0;
            for (int i = 0; i < newX.Length; i++)
            {
                if (newX[i] <= originalX[0])
                {
                    numArray[i] = originalY[0];
                }
                else if (newX[i] >= originalX[originalX.Length - 1])
                {
                    numArray[i] = originalY[originalX.Length - 1];
                }
                else
                {
                    for (int j = startIndex ; j < originalX.Length; j++)
                    {
                        if ((originalX[j] <= newX[i]) && (originalX[j + 1] >= newX[i]))
                        {
                            numArray[i] = (((newX[i] - originalX[j]) * (originalY[j + 1] - originalY[j])) / (originalX[j + 1] - originalX[j])) + originalY[j];
                            startIndex = j;
                            break;
                        }
                    }
                }
            }
            return numArray;
        }

        /// <summary>
        /// 获取一个序号，此序号为：给定X首次大于arr数组中某一值，这个值所对应的值得序号。
        /// </summary>
        /// <param name="xValue">给定的X值</param>
        /// <param name="waveArr">给定的arr</param>
        /// <returns></returns>
        public static int getCursorIndex(double xValue, double[] waveArr)
        {
            if (waveArr != null)
            {
                if (xValue >= waveArr[0] && xValue <= waveArr[waveArr.Length - 1])
                {
                    int index = 0;

                    for (int i = 0; i < waveArr.Length; i++)
                    {
                        if (waveArr[i] >= xValue)
                        {
                            index = i;
                            break;
                        }
                    }
                    return index;
                }
                else if(xValue <waveArr [0])
                {
                    return 0;
                }
                else if(xValue >waveArr [waveArr .Length -1])
                {
                    return waveArr.Length - 1;
                }
                else return -1;
            }
            else return -1;

        }

        public static int getCursorIndex(double xValue, int[] waveArr)
        {
            if (waveArr != null)
            {
                if (xValue >= waveArr[0] && xValue <= waveArr[waveArr.Length - 1])
                {
                    int index = 0;

                    for (int i = 0; i < waveArr.Length; i++)
                    {
                        if (waveArr[i] >= xValue)
                        {
                            index = i;
                            break;
                        }
                    }
                    return index;
                }
                else if (xValue < waveArr[0])
                {
                    return 0;
                }
                else if (xValue > waveArr[waveArr.Length - 1])
                {
                    return waveArr.Length - 1;
                }
                else return -1;
            }
            else return -1;

        }
        /// <summary>
        /// 由原数组，获取间隔1步长的新数组
        /// </summary>
        /// <param name="originalArray"></param>
        /// <returns></returns>
        public static int[] getOneStepArrayInt(double minWave,double MaxWave)
        {
            int length = (int)MaxWave - (int)minWave+1;
            int[] newArray = new int[length];
            for(int i=0;i<length;i++)
            {
                newArray[i] = (int)minWave  + i + 1;
            }
            return newArray;
        }
        /// <summary>
        /// 由原数组，获取间隔1步长的新数组
        /// </summary>
        /// <param name="originalArray"></param>
        /// <returns></returns>
        public static double[] getOneStepArrayDouble(double minWave, double MaxWave)
        {
            int length = (int)MaxWave - (int)minWave ;
            double[] newArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                newArray[i] =(int) minWave+ i + 1;
            }
            return newArray;
        }



        /// <summary>double[]转字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DoubleToString(this double[] data, string format = "", string separaor = ",")
        {
            if (data.Length < 1)
            {
                return "";
            }
            else
            {
                string rdata = string.Empty;
                for (int i = 0; i < data.Length; i++)
                {
                    if (!string.IsNullOrEmpty(format))
                        rdata += data[i].ToString(format) + separaor;
                    else
                        rdata += data[i].ToString() + separaor;
                }
                return rdata.Substring(0, rdata.Length - 1);
            }


        }
        /// <summary>double[]转字符串 带加密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DoubleToStringEncryption(this double[] data, string format = "", string separaor = ",")
        {
            string rdata = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                if (!string.IsNullOrEmpty(format))
                    rdata += data[i].ToString(format) + separaor;
                else
                    rdata += data[i].ToString() + separaor;
            }
            string str = rdata.Substring(0, rdata.Length - 1);
            return EncryptionHelper.Encrypt(str);
        }

        /// <summary>字符串转double[]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static double[] StringToDouble(this string wavemodel, char separaor = ',')
        {
            //string waveString=EncryptionHelper.Decrypt(wavemodel);
            string[] wavelststr = wavemodel.Split(separaor);
            double[] wavelst = new double[wavelststr.Length];
            for (int i = 0; i < wavelststr.Length; i++)
            {
                wavelst[i] = double.Parse(wavelststr[i].Trim());
            }
            return wavelst;
        }

        /// <summary>字符串转double[] 带解密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static double[] StringToDoubleEncryption(this string wavemodel, char separaor = ',')
        {
            string waveString = EncryptionHelper.Decrypt(wavemodel);
            string[] wavelststr = waveString.Split(separaor);
            double[] wavelst = new double[wavelststr.Length];
            for (int i = 0; i < wavelststr.Length; i++)
            {
                wavelst[i] = double.Parse(wavelststr[i].Trim());
            }
            return wavelst;
        }


        /// <summary>int[]转字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string IntToString(int[] data, string format = "", string separaor = ",")
        {
            string rdata = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                if (!string.IsNullOrEmpty(format))
                    rdata += data[i].ToString(format) + separaor;
                else
                    rdata += data[i].ToString() + separaor;
            }
            return rdata.Substring(0, rdata.Length - 1);
        }

        /// <summary>字符串转int[]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] StringToInt(this string wavemodel, char separaor = ',')
        {
            string[] wavelststr = wavemodel.Split(separaor);
            int[] wavelst = new int[wavelststr.Length];
            for (int i = 0; i < wavelststr.Length; i++)
            {
                wavelst[i] = int.Parse(wavelststr[i].Trim());
            }
            return wavelst;
        }
        /// <summary>
        /// 平滑处理
        /// </summary>
        /// <param name="spectrum">传入的数组</param>
        /// <param name="smoothWidth">平滑宽度</param>
        /// <returns></returns>
        public static double[] smoothProcess(double[] spectrum, int smoothWidth)
        {
            int count = smoothWidth * 2 + 1;
            double[] spectrum2 = spectrum;

            int end = spectrum.Length;

            for (int i = smoothWidth; i < end - smoothWidth; ++i)
            {
                double sum = 0D;
                for (int j = -smoothWidth; j < smoothWidth + 1; ++j)
                    sum += spectrum2[(i + j)];

                sum /= (2.0 * smoothWidth + 1);
                spectrum2[i] = sum;
            }
            for (int i = 0; i < smoothWidth; i++)
            {
                double sum2 = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum2 += spectrum2[j];
                }
                sum2 = sum2 / (i +1);
                spectrum2[i] = sum2;
            }
            for (int i = end - smoothWidth; i < end; i++)
            {
                double sum3 = 0;
                for (int j = i; j < end; j++)
                {
                    sum3 += spectrum2[ j];
                }
                sum3 = sum3 /( end-i);
                spectrum2[i] = sum3;
            }

            return spectrum2;
        }

        public static List<int> findPeaks(double[] spectrum,int peakWidth,int smoothWidth,int threshold)
        {
            double[] origenSpec = new double[spectrum.Length];
            Array.Copy(spectrum, origenSpec, origenSpec.Length);

            double[]  smoothedSpec=smoothProcess(spectrum, smoothWidth);

            //peakWidth个宽度的连续上升和下降代表寻找到1个峰
            List<int> peakList = new List<int>();

            for(int i= peakWidth+1;i< smoothedSpec.Length -peakWidth-1;i++)
            {
                bool peakState = true;
                for (int j=1;j<=peakWidth;j++)
                {
                    if(smoothedSpec[i-j-1]> smoothedSpec[i-j])
                    {
                        peakState = false;
                        break;
                    }
                }

                if (peakState)
                    for (int j = 1; j <= peakWidth; j++)
                    {
                        if (smoothedSpec[i+j+1] > smoothedSpec[i + j])
                        {
                            peakState = false;
                            break;
                        }
                    }

                if (peakState)
                    peakList.Add(i);

            }

            //超过threshold阈值宽度的峰，代表是1个峰
            //找出最大值和最小值，
            double maxvalue = smoothedSpec[0];
            double minvalue = smoothedSpec[0];
            
            for (int i=0;i<smoothedSpec .Length;i++)
            {
                if (smoothedSpec[i] < minvalue)
                {
                    minvalue = smoothedSpec[i];
                }
                else if(smoothedSpec [i]> maxvalue)
                {
                    maxvalue = smoothedSpec[i];
                }
            }

            List<int> peakList_thre = new List<int>();
            int width_compare = 10;
            for(int i=0;i<peakList .Count;i++)
            {
                double beforeValue=0, currentValue=0, afterValue=0;
                if (peakList[i] - 30 > 0&&peakList [i]+30<smoothedSpec.Length )
                {
                    for (int j = 0; j < width_compare; j++)
                    {
                        beforeValue += smoothedSpec[peakList[i] - width_compare*2 + j];
                        currentValue += smoothedSpec[peakList[i] - width_compare/2 + j];
                        afterValue += smoothedSpec[peakList[i] + width_compare + j];
                    }
                    beforeValue /= 6;
                    currentValue /= 6;
                    afterValue /= 6;

                    beforeValue = 100 * (beforeValue - minvalue) / (maxvalue - minvalue);
                    currentValue = 100 * (currentValue - minvalue) / (maxvalue - minvalue);
                    afterValue = 100 * (afterValue - minvalue) / (maxvalue - minvalue);

                    if (currentValue - beforeValue > threshold && currentValue - afterValue > threshold*0.5)
                    {
                        peakList_thre.Add(peakList[i]);
                    }
                }
            }

            List<int> peakList2 = new List<int>();
            for(int i=0;i< peakList_thre.Count;i++)
            {
                double max = origenSpec[peakList_thre[i]];
                int maxIndex = peakList_thre[i];
                
                for(int j=1;j<peakWidth;j++)
                {
                    if (max < origenSpec[peakList_thre[i]-j])
                    {
                        max = origenSpec[peakList_thre[i] - j];
                        maxIndex = peakList_thre[i] - j;
                    }
                }


                for (int j = 1; j <= peakWidth; j++)
                {
                    if (max < origenSpec[peakList_thre[i] + j])
                    {
                        max = origenSpec[peakList_thre[i] + j];
                        maxIndex = peakList_thre[i] + j;
                    }
                }


                peakList2.Add(maxIndex);
            }



            
            return peakList2;

        } 

    }
}
