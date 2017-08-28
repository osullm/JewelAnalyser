using JewelApp01.Processer;
using System;
using System.Data;
using System.Windows.Forms;

namespace JewelApp01.product
{

    public partial class ClassManager : Form
    {
        public delegate void RefreshHander();

        public event RefreshHander Onrefresh;

        public ClassManager()
        {
            InitializeComponent();
        }

        private void ClassManager_Load(object sender, EventArgs e)
        {
            string sqlstr = @"select * from ClassTable";
            //"select U_ID as 用户名 ,U_passwordas 密码,U_head as 开户人 from T_user"
            var dt = SqliteHelper.ExecDataTable(sqlstr);
            dgv_JewClass.Columns.Clear();
            bindingSource1.DataSource = dt;
            dgv_JewClass.DataSource = bindingSource1;

            dgv_JewClass.Columns[0].ReadOnly = true;
            //bindingSource.DataSource = dt;
            //bindingSource.ResetBindings(true);
            //做标记
            //this.Show();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable tb = bindingSource1.DataSource as DataTable;
            //tb.Rows.Add();
            tb.Rows.Add(new Object[] { tb.Rows.Count, "", "" });
            //tb.Rows[tb.Rows.Count-1]
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除?", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //foreach (DataRow dr in dgv_people .SelectedRows)
                // {
                var drv = bindingSource1.Current as DataRowView;
                bindingSource1.RemoveCurrent();
                //DataRowCollection
                //}

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = bindingSource1.DataSource as DataTable;
                SqliteHelper.ExecuteSql(" DELETE FROM ClassTable");

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr.RowState == DataRowState.Deleted)
                        continue;
                    if (string.IsNullOrEmpty(dr[0].ToString().Trim()) || string.IsNullOrEmpty(dr[1].ToString().Trim()))
                    {
                        MessageBox.Show("输入的名称不能为空！");
                        break;
                        //continue;
                    }

                    //SqliteHelper.SaveColumnFarmatSource(CurrFarmatData, false);
                    string sqlstr = "insert into ClassTable(ID,Name,Remark)values(@ID,@Name,@Remark)";
                    SqliteHelper.ExecuteSql(sqlstr, new
                    {
                        ID = dr[0],
                        Name = dr[1],
                        Remark = dr[2]
                    });

                }
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                //SqliteHelper.WriteLog(ex, new object());
                MessageBox.Show("保存失败!" + ex.Message);
                
            }
            finally
            {
                Onrefresh();
                this.Dispose();
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除?", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dgv_JewClass.SelectedRows.Count > 0)
                {
                    dgv_JewClass.Rows.Remove(dgv_JewClass.SelectedRows[0]);
                }
            }
        }
    }
}
