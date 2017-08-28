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
    public partial class Form_updateSql : Form
    {
        public Form_updateSql(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void Form_updateSql_Load(object sender, EventArgs e)
        {
            loadClassCreator();
            loadJewData(index );
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

        private void loadJewData(int ID)
        {
            //int index;
            //if (int.TryParse(dgv_searchRe.SelectedRows[0].Cells[0].Value.ToString(), out index))
            //{
                string sqlstr = "select Name,JewClass,Creator,Remark from JewDataTable  WHERE ID = " + ID ;
                var datalst = SqliteHelper.ExecDataTable(sqlstr);
                string name = (string)datalst.Rows[0]["Name"];
                string jewClass = (string)datalst.Rows[0]["JewClass"];
                string Creator = (string)datalst.Rows[0]["Creator"];
                string Remark= (string)datalst.Rows[0]["Remark"];

            txt_name.Text = name;
            txt_remark.Text = Remark;
            cbx_class.SelectedItem = jewClass;
            cbx_creator.SelectedItem = Creator;
            //ProcessFile.saveTwoArray(name, wave, spec);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string jewclass = cbx_class.SelectedItem.ToString();
            string creator = cbx_creator.SelectedItem.ToString();
            if (name!=string.Empty &&jewclass !=string .Empty &&creator !=string .Empty )
            {
                
                string remark = txt_remark.Text.Trim();
                string sqlstr = "UPDATE JewDataTable SET Name = '" + name + "' , JewClass = '" + jewclass + "' , Creator = '" + creator + "' , Remark = '" + remark + "'  WHERE ID = " + index;
                SqliteHelper.ExecuteSql(sqlstr);
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("请输入正常值！");
            }
            

        }
    }
}
