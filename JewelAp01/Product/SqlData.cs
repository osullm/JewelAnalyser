using JewelApp01.Model;
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
using TeeChart;

namespace JewelApp01.Product
{
    public partial class SqlData : Form
    {
        List<JewDataClass> jewDataList = new List<JewDataClass>();
        List<JewDataClass> selectedJewDataList = new List<JewDataClass>();
        public event AddSpecLineHander addSpecLine;
        public SqlData()
        {
            InitializeComponent();
        }

        private void SqlData_Load(object sender, EventArgs e)
        {
            cbx_class.Items.Clear();
            cbx_class.Items.Add("所有");
            cbx_creator.Items.Clear();
            cbx_creator.Items.Add("所有");
            cbx_class.SelectedIndex = 0;
            cbx_creator.SelectedIndex = 0;
            loadClassCreator();
            loadJewData();
        }

        private void loadClassCreator()
        {
            string str = "SELECT DISTINCT JewClass FROM JewDataTable";
            DataTable jewClasses = SqliteHelper.ExecDataTable(str);
            foreach (DataRow dr in jewClasses.Rows)
            {
                cbx_class.Items.Add(dr["JewClass"]);
            }

            str = "SELECT DISTINCT Creator FROM JewDataTable";
            DataTable creators = SqliteHelper.ExecDataTable(str);
            foreach (DataRow dr in creators.Rows)
            {
                cbx_creator.Items.Add(dr["Creator"]);
            }

        }

        private void loadJewData()
        {
            dgv_searchRe.Rows.Clear();
            jewDataList.Clear ();
            string sqlstr = "select * from JewDataTable  order by ID asc ";
            var datalst = SqliteHelper.ExecDataTable(sqlstr);
            lbl_reCount.Text = "查找结果：" + datalst.Rows.Count + " 条。";
            foreach (DataRow dr in datalst.Rows)
            {
                JewDataClass jewData = new Model.JewDataClass();
                jewData.jewId = (int)dr["ID"];
                jewData.jewName = (string)dr["Name"];
                jewData.jewClass = (string)dr["JewClass"];
                jewData.wavelength =ProcessArray .StringToDoubleEncryption   ( (string)dr["Wavelength"]);
                jewData.spectrum = ProcessArray.StringToDoubleEncryption ((string)dr["Spectrum"]);
                jewData.addTime = (string)dr["AddTime"];
                jewData.creator = (string)dr["Creator"];
                jewData.remark = (string)dr["Remark"];
                if(dr["RealSign"].ToString ()!="")
                    jewData.realSign = ProcessArray.StringToDouble((string)dr["RealSign"]).ToList ();
                if (dr["UnRealSign"].ToString() != "")
                    jewData.unRealSign  = ProcessArray.StringToDouble((string)dr["UnRealSign"]).ToList();
                jewDataList.Add(jewData);

                int index=dgv_searchRe.Rows.Add();
                dgv_searchRe.Rows[index].Cells[0].Value = jewData.jewId;
                dgv_searchRe.Rows[index].Cells[1].Value = jewData.jewName;
                dgv_searchRe.Rows[index].Cells[2].Value = jewData.jewClass;
                dgv_searchRe.Rows[index].Cells[3].Value = jewData.addTime;
                dgv_searchRe.Rows[index].Cells[4].Value = jewData.creator;
                dgv_searchRe.Rows[index].Cells[5].Value = jewData.remark;

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_searchRe.Rows.Clear();
            string key = txt_key.Text.Trim ();
            string className=cbx_class.SelectedItem.ToString();
            string creatorName = cbx_creator.SelectedItem.ToString();
            string sqlstr;
            jewDataList.Clear ();
            if(key==string.Empty )
            {
                // sqlstr = "select * from JewDataTable  order by ID asc ";

                if (cbx_class.SelectedIndex == 0 && cbx_creator.SelectedIndex == 0)
                {
                    sqlstr = "select * from JewDataTable  order by ID asc ";
                }
                else if (cbx_class.SelectedIndex != 0 && cbx_creator.SelectedIndex != 0)
                {
                    sqlstr = "select * from JewDataTable WHERE   JewClass like '" + className + "' AND  Creator like '" + creatorName + "' order by ID asc ";
                }
                else if (cbx_class.SelectedIndex != 0 && cbx_creator.SelectedIndex == 0)
                {
                    sqlstr = "select * from JewDataTable WHERE   JewClass like '" + className + "' order by ID asc ";
                }
                else
                {
                    sqlstr = "select * from JewDataTable WHERE    Creator like '" + creatorName + "' order by ID asc ";
                }

            }
            else
            {
                if (cbx_class.SelectedIndex == 0 && cbx_creator.SelectedIndex == 0)
                {
                    sqlstr = "select * from JewDataTable WHERE Name like '%" + key + "%' order by ID asc ";
                }
                else if (cbx_class.SelectedIndex != 0 && cbx_creator.SelectedIndex != 0)
                {
                    sqlstr = "select * from JewDataTable WHERE Name like '%" + key + "%' AND  JewClass like '" + className + "' AND  Creator like '" + creatorName + "' order by ID asc ";
                }
                else if (cbx_class.SelectedIndex != 0&&cbx_creator.SelectedIndex ==0)
                {
                    sqlstr = "select * from JewDataTable WHERE Name like '%" + key + "%' AND  JewClass like '" + className + "' order by ID asc ";
                }
                else
                {
                    sqlstr = "select * from JewDataTable WHERE Name like '%" + key + "%' AND   Creator like '" + creatorName + "' order by ID asc ";
                }
            }
             
            var datalst = SqliteHelper.ExecDataTable(sqlstr);

            lbl_reCount.Text = "查找结果：" + datalst.Rows.Count + " 条。";
            foreach (DataRow dr in datalst.Rows)
            {
                JewDataClass jewData = new Model.JewDataClass();
                jewData.jewId = (int)dr["ID"];
                jewData.jewName = (string)dr["Name"];
                jewData.jewClass = (string)dr["JewClass"];
                jewData.wavelength =ProcessArray .StringToDoubleEncryption  ( (string)dr["Wavelength"]);
                jewData.spectrum = ProcessArray.StringToDoubleEncryption ((string)dr["Spectrum"]);
                jewData.addTime = (string)dr["AddTime"];
                jewData.creator = (string)dr["Creator"];
                jewData.remark = (string)dr["Remark"];
                if (dr["RealSign"].ToString() != "")
                    jewData.realSign = ProcessArray.StringToDouble((string)dr["RealSign"]).ToList();
                if (dr["UnRealSign"].ToString() != "")
                    jewData.unRealSign  = ProcessArray.StringToDouble((string)dr["UnRealSign"]).ToList();
                //jewData.factoryState = (string)dr["Factory"];
                jewDataList.Add(jewData);

                int index = dgv_searchRe.Rows.Add();
                dgv_searchRe.Rows[index].Cells[0].Value = jewData.jewId;
                dgv_searchRe.Rows[index].Cells[1].Value = jewData.jewName;
                dgv_searchRe.Rows[index].Cells[2].Value = jewData.jewClass;
                dgv_searchRe.Rows[index].Cells[3].Value = jewData.addTime;
                dgv_searchRe.Rows[index].Cells[4].Value = jewData.creator;
                dgv_searchRe.Rows[index].Cells[5].Value = jewData.remark;

            }
        }

        //private void btn_select_Click(object sender, EventArgs e)
        //{
        //    if( dgv_searchRe.SelectedRows .Count >0)
        //    {
        //        int selectedindex = dgv_searchRe.CurrentRow.Index;
        //        selectedJewDataList.Add(jewDataList[selectedindex]);

        //        int index = dgv_selectedItem.Rows.Add();
        //        dgv_selectedItem.Rows[index].Cells[0].Value = jewDataList[selectedindex].jewId;
        //        dgv_selectedItem.Rows[index].Cells[1].Value = jewDataList[selectedindex].jewName;
        //        dgv_selectedItem.Rows[index].Cells[2].Value = jewDataList[selectedindex].jewClass;
        //        dgv_selectedItem.Rows[index].Cells[3].Value = jewDataList[selectedindex].addTime;
        //        dgv_selectedItem.Rows[index].Cells[4].Value = jewDataList[selectedindex].creator;
        //        dgv_selectedItem.Rows[index].Cells[5].Value = jewDataList[selectedindex].remark;
        //    }
        //}

        //private void btn_remove_Click(object sender, EventArgs e)
        //{

        //    if(dgv_selectedItem.SelectedRows.Count >0)
        //    {
        //        int selectedIndex = dgv_selectedItem.CurrentRow.Index;
        //        dgv_selectedItem.Rows.RemoveAt(selectedIndex);
        //        selectedJewDataList.RemoveAt(selectedIndex);
        //    }
            
        //}

        private void dgv_searchRe_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = dgv_searchRe.CurrentRow.Index;
            axTChart1.Series(0).Title = jewDataList[selectedIndex].jewName;
            axTChart1.Series(0).AddArray(jewDataList[selectedIndex].wavelength.Length, jewDataList[selectedIndex].spectrum , jewDataList[selectedIndex].wavelength);
            addSignFittingChart(jewDataList[selectedIndex].wavelength, jewDataList[selectedIndex].spectrum, jewDataList[selectedIndex].realSign.ToArray(), jewDataList[selectedIndex].unRealSign.ToArray());
            addSignToGrid(jewDataList[selectedIndex].realSign.ToArray(), jewDataList[selectedIndex].unRealSign.ToArray());
        }

        private void dgv_searchRe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgv_searchRe.ClearSelection();
                    dgv_searchRe.Rows[e.RowIndex].Selected = true;
                    //dgv_searchRe.CurrentCell = dgv_searchRe.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //contextMenuStrip_ListViewItemRightClick.Show（MousePosition.X， MousePosition.Y）; 
                }
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int index ;
            string creator = dgv_searchRe.SelectedRows[0].Cells[4].Value.ToString();
            if(creator =="法宝技术")
            {
                MessageBox.Show("无法删除厂家数据！");
                return;
            }
             if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            {
                string sqlstr = "DELETE FROM JewDataTable WHERE ID =  " + index ;
                SqliteHelper.ExecuteSql(sqlstr);
                //dgv_searchRe.Rows.Remove(dgv_searchRe.SelectedRows[0]);
                btn_search.PerformClick();
            }
            
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int index ;
            string creator = dgv_searchRe.SelectedRows[0].Cells[4].Value.ToString();
            if (creator == "法宝技术")
            {
                MessageBox.Show("无法导出厂家数据！");
                return;
            }
            if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            {
                string sqlstr = "select Name,Wavelength,Spectrum from JewDataTable  WHERE ID = "+ index;
                var datalst = SqliteHelper.ExecDataTable(sqlstr);
                string name = (string)datalst.Rows[0]["Name"];
                double[] wave = ProcessArray.StringToDoubleEncryption  ((string)datalst.Rows[0]["Wavelength"]);
                double[] spec = ProcessArray.StringToDoubleEncryption ((string)datalst.Rows[0]["Spectrum"]);
                
                ProcessFile .saveCurrentTwoArray(name,wave,spec);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int index ;
            string creator = dgv_searchRe.SelectedRows[0].Cells[4].Value.ToString();
            if (creator == "法宝技术")
            {
                MessageBox.Show("无法导出厂家数据！");
                return;
            }
            if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            {
                string sqlstr = "select * from JewDataTable  WHERE ID = " + index;
                var datalst = SqliteHelper.ExecDataTable(sqlstr);
                string name = (string)datalst.Rows[0]["Name"];
                double[] wave = ProcessArray.StringToDouble((string)datalst.Rows[0]["Wavelength"]);
                double[] spec = ProcessArray.StringToDouble((string)datalst.Rows[0]["Spectrum"]);

                Form_updateSql updateSql = new Form_updateSql(index );
                updateSql.Show();
            }
        }

        //private void dgv_selectedItem_SelectionChanged(object sender, EventArgs e)
        //{
        //    for (int i = axTChart1.SeriesCount - 1; i > 0; i--)
        //        axTChart1.RemoveSeries(i);



        //    for (int i = 0; i < dgv_selectedItem.SelectedRows.Count; i++)
        //    {
        //        int selectedIndex = dgv_selectedItem.SelectedRows[i].Index;
        //        ESeriesClass series = new ESeriesClass();
        //        int index = axTChart1.AddSeries(series);
        //        axTChart1.Series(index).Title = selectedJewDataList[selectedIndex].jewName;
        //        axTChart1.Series(index).AddArray(selectedJewDataList[selectedIndex].wavelength.Length, selectedJewDataList[selectedIndex].spectrum, selectedJewDataList[selectedIndex].wavelength);
        //        addSignFittingChart(selectedJewDataList[selectedIndex].wavelength, selectedJewDataList[selectedIndex].spectrum, selectedJewDataList[selectedIndex].realSign.ToArray (), selectedJewDataList[selectedIndex].unRealSign.ToArray ());
        //    }
        //}

        private void 导出到光谱图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            {
                string sqlstr = "select Name,Wavelength,Spectrum from JewDataTable  WHERE ID = " + index;
                var datalst = SqliteHelper.ExecDataTable(sqlstr);
                string name = (string)datalst.Rows[0]["Name"];
                double[] wave = ProcessArray.StringToDoubleEncryption((string)datalst.Rows[0]["Wavelength"]);
                double[] spec = ProcessArray.StringToDoubleEncryption((string)datalst.Rows[0]["Spectrum"]);

                //ProcessFile.saveTwoArray(name, wave, spec);
                addSpecLine(spec, wave, name);
            }
        }

        private void addCurser(AxTeeChart.AxTChart chart, List<double> realSign, List<double> unRealSign)
        {
            //Color realSignColor=Color.Green;
            //Color unRealSignColor = Color.Red;

            for(int i=0;i<realSign.Count ;i++)
            {
                int cursorIndex = chart.Tools.Add(EToolClass.tcCursor);
                chart.Tools.Items[cursorIndex].asTeeCursor.Pen.Color = (uint)Color.Green.ToArgb();
                chart.Tools.Items[cursorIndex].asTeeCursor.Pen.Width = 2;
                chart.Tools.Items[cursorIndex].asTeeCursor.XVal = realSign[i];
            }
            for (int i = 0; i < unRealSign.Count; i++)
            {
                int cursorIndex = chart.Tools.Add(EToolClass.tcCursor);
                chart.Tools.Items[cursorIndex].asTeeCursor.Pen.Color = (uint)Color.Red .ToArgb();
                chart.Tools.Items[cursorIndex].asTeeCursor.Pen.Width = 2;
                chart.Tools.Items[cursorIndex].asTeeCursor.XVal = unRealSign[i];
            }


        }

        private void addSignFittingChart(double[] bufwave, double[] bufspec, double[] realSign, double[] unrealSign)
        {
            for (int i = axTChart1.SeriesCount - 1; i > 1; i--)
            {
                axTChart1.RemoveSeries(i);
            }
            axTChart1.Series(1).Clear();

            if (realSign.Length == 0 && unrealSign.Length == 0)
                return;

            double[] markx = new double[realSign.Length + unrealSign.Length];
            double[] marky = new double[realSign.Length + unrealSign.Length];


            for (int i = 0; i < realSign.Length; i++)
            {
                //ESeriesClass lineSeries = new ESeriesClass();
                int waveindex = ProcessArray.getCursorIndex(realSign[i], bufwave);
                double[] newserArrayY = new double[] { 0, bufspec[waveindex] };
                double[] newserArrayX = new double[] { realSign[i], realSign[i] };
                int index = axTChart1.AddSeries(ESeriesClass.scFastLine);
                axTChart1.Series(index).AddArray(2, newserArrayY, newserArrayX);
                axTChart1.Series(index).asFastLine.LinePen.Width = 2;
                axTChart1.Series(index).asFastLine.LinePen.Color = (uint)ColorTranslator.ToWin32(Color.Green);

                markx[i] = realSign[i];
                marky[i] = bufspec[waveindex];
                //int index=Chart_fitting.Tools.Add(EToolClass.tcCursor);
                //Chart_fitting.Tools.Items[index].asTeeCursor.Series = Chart_fitting.Series(0);
                //Chart_fitting.Tools.Items[index].asTeeCursor.Style = ECursorToolStyle.cssVertical;
                //Chart_fitting.Tools.Items[index].asTeeCursor.XVal = realSign[i];
                //Chart_fitting.Tools.Items[index].asTeeCursor.Pen.Color = (uint)ColorTranslator.ToWin32(Color.Green);
                //Chart_fitting.Tools.Items[index].asTeeCursor.Pen.Width = 2;
            }
            for (int i = 0; i < unrealSign.Length; i++)
            {
                int waveindex = ProcessArray.getCursorIndex(unrealSign[i], bufwave);
                double[] newserArrayY = new double[] { 0, bufspec[waveindex] };
                double[] newserArrayX = new double[] { unrealSign[i], unrealSign[i] };
                int index = axTChart1.AddSeries(ESeriesClass.scFastLine);
                axTChart1.Series(index).AddArray(2, newserArrayY, newserArrayX);
                axTChart1.Series(index).asFastLine.LinePen.Width = 2;
                axTChart1.Series(index).asFastLine.LinePen.Color = (uint)ColorTranslator.ToWin32(Color.Red);

                markx[i + realSign.Length] = unrealSign[i];
                marky[i + realSign.Length] = bufspec[waveindex];

            }
            int serindex = 1;
            axTChart1.Series(serindex).AddArray(marky.Length, marky, markx);
            axTChart1.Series(serindex).asPoint.Pointer.Visible = false;
            axTChart1.Series(serindex).Marks.Style = EMarkStyle.smsXValue;
            axTChart1.Series(serindex).Marks.Symbol.Visible = false;
            axTChart1.Series(serindex).Marks.Show();
        }

        private void addSignToGrid(double[] real, double[] unreal)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < real.Length; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                dataGridView1.Rows[i].Cells[0].Value = real[i].ToString();
            }

            for (int i = 0; i < unreal.Length; i++)
            {
                if (i < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[i].Cells[1].Value = unreal[i].ToString();
                }
                else
                {
                    dataGridView1.Rows.Add(new DataGridViewRow());
                    dataGridView1.Rows[i].Cells[1].Value = unreal[i].ToString();
                }
            }

        }
    }
}
