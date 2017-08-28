using System;
using System.ComponentModel;
using System.Windows.Forms;
using JewelApp01.Model;
using JewelApp01.Processer;
using System.Data;
using System.Collections.Generic;

namespace JewelApp01.Control
{
    [ToolboxItem(true)]


    //声明一个添加谱线的委托
    //public delegate void AddLinesHander(object wave,double[] spec,bool  firstSeries);
    public delegate void SelectTablePage(int index);
    public delegate void StopGetSpec();
    public delegate void SetRemarks(string text);
    public delegate void setSignsHander(int[] wave,double[] spec,double[] realSign, double[] UnRealSign);

    public partial class FittingControl : UserControl
    {
        //public SpecInfoClass specInfo { get; set; }
        public ProcessSpec processSpec { set; get; }
        public DataTable dt_fitting { get; set; }

        private DataTable dt_show;
        //在委托的机制下建立添加谱线的事件
        public event AddLinesHander OnAddLines;
        public event StopGetSpec stopGetSpec;
        public event SelectTablePage selectTablePage2;
        public event SetRemarks setRemarks;
        public event AddSpecLineHander addSpecLine;
        public event setSignsHander setSignEvent;

        public FittingControl()
        {
            InitializeComponent();
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (!processSpec.IsConn)
                    return;
                stopGetSpec();

                double[] oneWave = ProcessArray.getOneStepArrayDouble(processSpec.ShowWavelength_MinMax[0], processSpec.ShowWavelength_MinMax[1]);
                double[] oneSpec = ProcessArray.FixArrayY(oneWave, processSpec.wavelengths, processSpec.showY);
                OnAddLines(oneWave, oneSpec, false, "当前谱图");//添加待耦合的曲线。

                dt_fitting = processFitting.sqlFitting(processSpec.wavelengths, processSpec.showY, processSpec.ShowWavelength_MinMax[0], processSpec.ShowWavelength_MinMax[1]);
                
                dt_show = getThresholdDataTable(dt_fitting, (int)nud_threshold.Value);

                dgv_fittingResult.DataSource = sortDataTable(dt_show,10);
                for (int i = 0; i < dgv_fittingResult.Columns.Count; i++)
                {
                    dgv_fittingResult.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                for (int i = 9; i > 3; i--)
                {
                    dgv_fittingResult.Columns[i].Visible = false;
                }
                selectTablePage2(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("拟合失败！" + ex.Message);
            }
        }

        private DataTable getThresholdDataTable(DataTable dt,int threshold)
        {
            DataTable newdt = new DataTable();

            //DataRow[] rows = dt.Select("FittingResult >=" + threshold.ToString ()); // 从dt 中查询符合条件的记录；             
            newdt = dt.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据； 

            foreach (DataRow row in dt .Rows )  // 将查询的结果添加到dt中； 
            {
                if(double.Parse (row["FittingResult"].ToString ())>= threshold)
                newdt.Rows.Add(row.ItemArray);
            }

            //newdt.DefaultView.Sort = "FittingResult desc";
            return newdt.DefaultView.ToTable(); ;
        }

        private void nud_threshold_ValueChanged(object sender, EventArgs e)
        {
            if (dt_fitting != null)
            {
                dt_show = getThresholdDataTable(dt_fitting, (int)nud_threshold.Value);
                //dt_show.DefaultView.Sort = "FittingResult DESC";
                dgv_fittingResult.DataSource = sortDataTable(dt_show, 10);
                for(int i=0;i<dgv_fittingResult .Columns .Count;i++)
                {
                    dgv_fittingResult.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                for (int i = 9; i > 3; i--)
                {
                    dgv_fittingResult.Columns[i].Visible = false;
                }
            }
        }

        private void dgv_fittingResult_SelectionChanged(object sender, EventArgs e)
        {
            OnAddLines(new object(), null,false,"当前谱图");//清空除了第一条线之外的谱线；

            foreach (DataGridViewRow dr in dgv_fittingResult.SelectedRows)
            {
                //int index = dgv_fittingResult.SelectedRows[i].Index;
                //DataRow dtr = dt_fitting.Rows[index];

                int[] wave = ProcessArray.StringToInt((string)dr.Cells["Wavelength"].Value);
                double[] spec = ProcessArray.StringToDouble((string)dr.Cells["Spectrum"].Value);
                string remark = dr.Cells["Remark"].Value.ToString();
                string name = dr.Cells["Name"].Value .ToString ();
                double[] realSign=new double[0], unrealSign=new double[0];
                if (dr.Cells["RealSign"].Value.ToString ()!="")
                    realSign = ProcessArray.StringToDouble((string)dr.Cells["RealSign"].Value);
                if(dr.Cells["UnRealSign"].Value.ToString() != "")
                    unrealSign = ProcessArray.StringToDouble((string)dr.Cells["UnRealSign"].Value);
                addSignToGrid(realSign, unrealSign);

               
                OnAddLines(wave, spec, true,name);
                setRemarks(remark);

                setSignEvent(wave, spec, realSign, unrealSign);
            }
        }

        private void 加入光谱图对比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_fittingResult.SelectedRows.Count > 0)
            {


                double[] wave = ProcessArray.StringToDouble((string)dgv_fittingResult.SelectedRows[0].Cells["Wavelength"].Value);
                double[] spec = ProcessArray.StringToDouble((string)dgv_fittingResult.SelectedRows[0].Cells["Spectrum"].Value);
                string remark = dgv_fittingResult.SelectedRows[0].Cells["Remark"].Value.ToString();
                string name = dgv_fittingResult.SelectedRows[0].Cells["Name"].Value.ToString();

                addSpecLine(spec, wave, name);
                //OnAddLines(wave, spec, true, name);
                //setRemarks(remark);
            }
        }

        private void dgv_fittingResult_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgv_fittingResult .ClearSelection();
                    dgv_fittingResult.Rows[e.RowIndex].Selected = true;
                    //dgv_searchRe.CurrentCell = dgv_searchRe.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //contextMenuStrip_ListViewItemRightClick.Show（MousePosition.X， MousePosition.Y）; 
                }
            }
        }

        private void addSignToGrid(double[] real,double[] unreal)
        {
            dataGridView1.Rows.Clear();

            for (int i=0;i<real.Length;i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                dataGridView1.Rows[i].Cells[0].Value = real[i].ToString();
            }
            
            for(int i=0;i<unreal .Length;i++)
            {
                if (i < dataGridView1.Rows.Count )
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

        private DataTable sortDataTable(DataTable intable,int sortColumnIndex)
        {
            int count = intable.Rows.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = count  - 1; j > i; j--)
                {
                    double fitj = double.Parse(intable.Rows[j].ItemArray[sortColumnIndex].ToString());
                    double fitj1 = double.Parse(intable.Rows[j - 1].ItemArray[sortColumnIndex].ToString());
                    if (fitj > fitj1)
                    {

                        var a = intable.Rows[j].ItemArray;
                        intable.Rows[j].ItemArray = intable.Rows[j - 1].ItemArray;
                        intable.Rows[j - 1].ItemArray = a;
                    }

                }

            }
            return intable;
        }


    }
}
