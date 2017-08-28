using JewelApp01.Processer;
using System;
using System.Data;
using System.Windows.Forms;

namespace JewelApp01.product
{
    public partial class PeopleManager : Form
    {
        public delegate void refreshHander();
        public event refreshHander onRefresh;

        public PeopleManager()
        {
            InitializeComponent();
        }
        private void PeopleManagment_Load(object sender, EventArgs e)
        {
            string sqlstr = @"select * from CreatorTable";
            //"select U_ID as 用户名 ,U_passwordas 密码,U_head as 开户人 from T_user"
            var dt = SqliteHelper.ExecDataTable(sqlstr);
            dgv_people.Columns.Clear();
            bindingSource1.DataSource = dt;
            dgv_people.DataSource = bindingSource1 ;

            dgv_people.Columns[0].ReadOnly = true;

            //bindingSource.DataSource = dt;
            //bindingSource.ResetBindings(true);
            //做标记
            //this.Show();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable tb = bindingSource1.DataSource as DataTable;
            //int maxSV = tb.AsEnumerable().Select(t => t.Field<int>("ID")).Max();
            tb.Rows.Add(new Object [] { tb.Rows.Count ,"",""});

            //DataRow dr = tb.NewRow();
            //dr["ID"] = tb.Rows.Count;
            ////dr["zbid"] = zbid;
            //tb.Rows.Add(dr);
            //bindingSource1.ResetBindings(false);

            //int maxUP = tb.AsEnumerable().Select(t => t.Field<int>("UnitPrice")).Max();

            //while (tb.Columns[0].)
            //tb.Rows[tb.Rows.Count-1]
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除?", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
               //foreach (DataRow dr in dgv_people .SelectedRows)
               // {
                    //var drv = bindingSource1.Current as DataRowView;
                    //bindingSource1.RemoveCurrent();
                //DataRowCollection
                //}


                if ((bindingSource1.DataSource as DataTable).Rows.Count == 0)
                    return;
                (bindingSource1.DataSource as DataTable).Rows.Remove((bindingSource1.Current as DataRowView).Row);
                int index = 0;
                foreach (DataRow dr in (bindingSource1.DataSource as DataTable).Rows)
                {
                    dr["id"] = index;
                    index++;
                }
                bindingSource1.ResetBindings(false);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = bindingSource1.DataSource as DataTable;
            SqliteHelper.ExecuteSql(" DELETE FROM CreatorTable");

            foreach (DataRow dr in dt.Rows)
                {
                    if (dr.RowState == DataRowState.Deleted)
                        continue;
                    if (string.IsNullOrEmpty(dr[0].ToString().Trim ()) || string.IsNullOrEmpty(dr[1].ToString().Trim ()) )
                    {
                        MessageBox.Show("输入的名称不能为空！");
                        break;
                        //continue;
                    }

                //SqliteHelper.SaveColumnFarmatSource(CurrFarmatData, false);
                string sqlstr = "insert into CreatorTable(ID,Name,Remark)values(@ID,@Name,@Remark)";
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
                MessageBox.Show("保存失败!"+ex .Message );
            }
            finally
            {
                onRefresh();
                this.Dispose();
            }
        }
    }
}
