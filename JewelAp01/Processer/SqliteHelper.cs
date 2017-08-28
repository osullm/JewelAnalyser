using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Dynamic;
using System.Reflection;
using System.Data.Common;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using JewelApp01.Model;
using System.IO;

namespace JewelApp01.Processer
{
    public static class SqliteHelper
    {
        #region 字段/属性

        /// <summary>数据库连接
        /// </summary>
        public static SQLiteConnection Conn { get { return SqliteHelperConnection(); } }

        
        /// <summary>数据库路径
        /// </summary>
        public static string Path { get; set; }= Environment.CurrentDirectory + "\\JewelData.db";


        #endregion

        /// <summary>地址建立连接
        /// <param name="path"></param>
        public static SQLiteConnection SqliteHelperConnection()
        {
            string connstr = "Data Source=" + Path + ";Version=3;Pooling=true;FailIfMissing=false";
            //Data Source = test.db; Pooling = true; FailIfMissing = false;
            SQLiteConnection conn = new SQLiteConnection(connstr);
            
            conn.Open();
            return conn;
        }

        #region 公有方法





        /// <summary>执行SQL不返回
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteSql(string sql, object para = null)
        {
            using (SQLiteConnection Conn = SqliteHelperConnection())
            {
                var cmd = new SQLiteCommand(Conn);
                cmd.CommandText = sql;
                if (para != null)
                {
                    Type type = para.GetType();
                    foreach (PropertyInfo p in type.GetProperties())
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@" + p.Name, p.GetValue(para, null)));
                    }
                }

                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>查询sql语句返回第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, object para = null)
        {
            using (SQLiteConnection Conn = SqliteHelperConnection())
            {
                //Conn.SetPassword("123456*fabao");
                var cmd = new SQLiteCommand(Conn);
                cmd.CommandText = sql;
                if (para != null)
                {
                    Type type = para.GetType();
                    foreach (PropertyInfo p in type.GetProperties())
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@" + p.Name, p.GetValue(para, null)));
                    }
                }
                object o = cmd.ExecuteScalar();
                return o;
            }
        }

        /// <summary>查询sql语句返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ExecDataTable(string sql)
        {
            using (SQLiteConnection Conn = SqliteHelperConnection())
            {
                var cmd = new SQLiteCommand(sql, Conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        /// <summary>查询sql语句返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet ExecDataSet(string sql)
        {
            using (SQLiteConnection Conn = SqliteHelperConnection())
            {
                var cmd = new SQLiteCommand(sql, Conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        /// <summary>查询sql语句返回动态对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<dynamic> ExecDynamic(string sql)
        {
            List<dynamic> dynamiclst = new List<dynamic>();
            DataTable dt = ExecDataTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                dynamic o = new ExpandoObject();
                var dic = (IDictionary<string, object>)o;
                foreach (DataColumn dc in dt.Columns)
                {
                    dic.Add(dc.ColumnName, dr[dc.ColumnName]);
                }
                dynamiclst.Add(o);
            }
            return dynamiclst;
        }



        /// <summary>存入实体对象
        /// </summary>
        /// <typeparam name="T">模型</typeparam>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static bool ExecSeveModel<T>(T data) where T : class
        {
            string beforesqlstr = string.Empty;
            string aftersqlstr = string.Empty;

            Type type = typeof(T);
            var attributes = type.GetCustomAttributesData();//取出表名
            string cn = (string)attributes[0].ConstructorArguments[0].Value;

            beforesqlstr += "insert into " + cn + "(";
            aftersqlstr += ") values(";
            foreach (PropertyInfo p in type.GetProperties())
            {
                if (p.GetValue(data, null) != null)
                {
                    var alst = p.GetCustomAttributesData();//取出字段名
                    string pn = (string)alst[0].ConstructorArguments[0].Value;
                    bool AutoInCrement = (bool)alst[0].ConstructorArguments[1].Value;
                    if (AutoInCrement == true)
                        continue;
                    beforesqlstr += pn + ",";
                    aftersqlstr += "'" + p.GetValue(data, null) + "',";
                }
            }
            string sqlstr = beforesqlstr.Substring(0, beforesqlstr.Length - 1) + aftersqlstr.Substring(0, aftersqlstr.Length - 1) + ")\r\n";
            if (ExecuteSql(sqlstr) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>读取实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> ExecReadModel<T>() where T : new()
        {
            Type type = typeof(T);
            var attributes = type.GetCustomAttributesData();//取出表名
            
            string cn = (string)attributes[0].ConstructorArguments[0].Value;
            string sqlstr = "select * from " + cn + " where ifnull(delmark,'N') = 'N'";
            DataTable dt = ExecDataTable(sqlstr);
            List<T> data = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                T model = new T();
                foreach (PropertyInfo p in type.GetProperties())
                {
                    var alst = p.GetCustomAttributesData();//取出字段名
                    string pn = (string)alst[0].ConstructorArguments[0].Value;
                    if (p.PropertyType == typeof(bool))
                    {
                        if (dr[pn] == DBNull.Value || (string)dr[pn] == "N")
                            p.SetValue(model, false, null);
                        else if ((string)dr[pn] == "Y")
                            p.SetValue(model, true, null);
                    }
                    else if (p.PropertyType == typeof(double[]))
                    {
                        p.SetValue(model, ((string)dr[pn]).StringToDouble('\n'), null);
                    }
                    else if (p.PropertyType == typeof(int))
                    {
                        p.SetValue(model, (int)dr[pn], null);
                    }
                    else
                    {
                        p.SetValue(model, dr[pn], null);
                    }
                }
                data.Add(model);
            }
            return data;
        }




        /// <summary>保存Jew数据
        /// </summary>
        /// <param name="data"></param>
        /// <param name="IsDelete"></param>
        public static void SaveJewData(JewDataClass jewData)
        {

            string sqlstr = @"insert into JewDataTable(ID,Name,JewClass,Wavelength,Spectrum,AddTime,Creator,Remark,RealSign,UnRealSign)values(@ID,@Name,@JewClass,@Wavelength,@Spectrum,@AddTime,@Creator,@Remark,@RealSign,@UnRealSign)";
            SqliteHelper.ExecuteSql(sqlstr, new
            {
                ID = jewData.jewId,
                Name = jewData.jewName,
                JewClass = jewData.jewClass,
                Wavelength = ProcessArray.DoubleToStringEncryption(jewData.wavelength),
                Spectrum = ProcessArray.DoubleToStringEncryption(jewData.spectrum),
                AddTime = jewData.addTime,
                Creator = jewData.creator,
                Remark = jewData.remark,
                RealSign= ProcessArray.DoubleToString (jewData.realSign.ToArray () ),
                UnRealSign= ProcessArray.DoubleToString (jewData.unRealSign .ToArray ())
            });

        }
        /// <summary>
        /// 删除jewData数据
        /// </summary>
        /// <param name="sampleId"></param>
        public static void deleteJewData(int sampleId)
        {
                SqliteHelper.ExecuteSql("delete from JewDataTable where ID = @ID", new { sampleId });
        }


        #endregion


        
    }

}
