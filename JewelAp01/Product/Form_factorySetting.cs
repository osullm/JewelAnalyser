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

namespace JewelApp01.Product
{
    public partial class Form_factorySetting : Form
    {
        List<JewDataClass> jewDataList = new List<JewDataClass>();
        List<JewDataClass> selectedJewDataList = new List<JewDataClass>();
        public Form_factorySetting()
        {
            InitializeComponent();
        }

        private void Form_factorySetting_Load(object sender, EventArgs e)
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
            jewDataList.Clear();
            string sqlstr = "select * from JewDataTable  order by ID asc ";
            var datalst = SqliteHelper.ExecDataTable(sqlstr);
            lbl_reCount.Text = "查找结果：" + datalst.Rows.Count + " 条。";
            foreach (DataRow dr in datalst.Rows)
            {
                JewDataClass jewData = new Model.JewDataClass();
                jewData.jewId = (int)dr["ID"];
                jewData.jewName = (string)dr["Name"];
                jewData.jewClass = (string)dr["JewClass"];
                jewData.wavelength = ProcessArray.StringToDouble((string)dr["Wavelength"]);
                jewData.spectrum = ProcessArray.StringToDouble((string)dr["Spectrum"]);
                jewData.addTime = (string)dr["AddTime"];
                jewData.creator = (string)dr["Creator"];
                jewData.remark = (string)dr["Remark"];
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

        private void dgv_searchRe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgv_searchRe.ClearSelection();
                    dgv_searchRe.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void 删除谱图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            {
                string sqlstr = "DELETE FROM JewDataTable WHERE ID =  " + index;
                SqliteHelper.ExecuteSql(sqlstr);
                //dgv_searchRe.Rows.Remove(dgv_searchRe.SelectedRows[0]);
                btn_search.PerformClick();
            }
        }

        private void 修改谱图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            {
                string sqlstr = "select * from JewDataTable  WHERE ID = " + index;
                var datalst = SqliteHelper.ExecDataTable(sqlstr);
                string name = (string)datalst.Rows[0]["Name"];
                double[] wave = ProcessArray.StringToDouble((string)datalst.Rows[0]["Wavelength"]);
                double[] spec = ProcessArray.StringToDouble((string)datalst.Rows[0]["Spectrum"]);

                Form_updateSql updateSql = new Form_updateSql(index);
                updateSql.Show();
            }
        }

        private void 导出谱图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            {
                string sqlstr = "select Name,Wavelength,Spectrum from JewDataTable  WHERE ID = " + index;
                var datalst = SqliteHelper.ExecDataTable(sqlstr);
                string name = (string)datalst.Rows[0]["Name"];
                double[] wave = ProcessArray.StringToDouble((string)datalst.Rows[0]["Wavelength"]);
                double[] spec = ProcessArray.StringToDouble((string)datalst.Rows[0]["Spectrum"]);

                ProcessFile.saveCurrentTwoArray(name, wave, spec);
            }
        }

        private void 设置为客户谱图ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
