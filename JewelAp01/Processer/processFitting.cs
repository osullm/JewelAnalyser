using JewelApp01.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using JewelApp01.Processer;

namespace JewelApp01.Processer
{
    public static class processFitting
    {

        public static DataTable  sqlFitting(double[] X1,double [] Y1,double minWave,double maxWave )
        {
            double[] x1Fixed = ProcessArray.getOneStepArrayDouble(minWave ,maxWave );
            double[] y1Fixed = ProcessArray.FixArrayY(x1Fixed, X1, Y1);
            List<JewDataClass> sqlDataList = new List<Model.JewDataClass>();


            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            //stopwatch.Start();
            //任务 1...  

            string sqlstr = "select * from JewDataTable  order by ID asc ";
            var datalst = SqliteHelper.ExecDataTable(sqlstr);
            datalst.Columns.Add("FittingResult");

            foreach (DataRow dr in datalst.Rows)
            {
                

                double[] wave = ProcessArray.StringToDoubleEncryption((string)dr["wavelength"]);
                double[] spec = ProcessArray.StringToDoubleEncryption((string)dr["Spectrum"]);

                dr["FittingResult"] = (100*fitting(x1Fixed, y1Fixed, wave, spec)).ToString ("f2");

                dr["wavelength"] = EncryptionHelper.Decrypt(dr["wavelength"].ToString());
                dr["Spectrum"] = EncryptionHelper.Decrypt(dr["Spectrum"].ToString());

            }
            //for(int i=7;i>2;i--)
            //{
            //    datalst.Columns[i];
            //}
            
            return datalst;

            

            //ProductSource.DataSource = datalst;
            //ProductSource.ResetBindings(false);
            //stopwatch.Stop();
            //MessageBox.Show ( "<p>任务 1 用时：" + stopwatch.ElapsedMilliseconds + "。</p>");
        }

        public static double fitting(double[] X1,double[] Y1,double[] X2,double [] Y2)
        {
            cutArray(ref X1,ref Y1,ref X2,ref Y2);
            if (X1 == null)
                return 0;
            double Xaverage = X1.Average();
            double y1Average = Y1.Average();
            double y2Average = Y2.Average();

            double  sum1=0 ,sum2=0,sum3=0;
            
            for (int i = 0; i < X1.Length; i++)
            {
                sum1 += ((Y1[i] - y1Average) * (Y2[i] - y2Average));
                sum2 += ((Y1[i] - y1Average) * (Y1[i] - y1Average));
                sum3 += ((Y2[i] - y2Average) * (Y2[i] - y2Average));
            }
            sum2 = Math.Sqrt (sum2 * sum3);
            return (double)(sum1 / sum2);
        }

        private  static void  cutArray(ref double[] X1, ref double[] Y1, ref double[] X2,ref double[] Y2)
        {
            double start = X1[0] > X2[0] ? X1[0] : X2[0];
            double end = X1[X1.Length -1] < X2[X2.Length -1] ? X1[X1.Length -1] : X2[X2.Length -1];
            if (X1[0] > X2[X2.Length - 1] || X2[0] > X1[X1.Length - 1])
            {
                X1 = null;
                Y1 = null;
                X2 = null;
                Y2 = null;
                return;
            }
            double[] x1 = new double[(int)end - (int)start + 1];
            double[] x2 = new double[(int)end - (int)start + 1];
            double[] y1 = new double[(int)end - (int)start + 1];
            double[] y2 = new double[(int)end - (int)start + 1];

            Array.Copy(X1, (int)start - (int)X1[0], x1,  0, (int)end - (int)start + 1);
            Array.Copy(X1, (int)start - (int)X1[0], x2, 0, (int)end - (int)start + 1);
            Array.Copy(Y1, (int)start - (int)X1[0], y1, 0, (int)end - (int)start + 1);
            Array.Copy(Y2, (int)start - (int)X2[0], y2, 0, (int)end - (int)start + 1);

            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;

        }


    }
}
