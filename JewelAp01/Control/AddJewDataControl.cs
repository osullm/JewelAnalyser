using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JewelApp01.Model;
using JewelApp01.Processer;
using JewelApp01.product;

namespace JewelApp01.Control
{
    public partial class AddJewDataControl : UserControl
    {
        [ToolboxItem(true)]


        //public SpecInfoClass specInfo { get; set; }
        public ProcessSpec processSpec { set; get; }


        public AddJewDataControl()
        {
            InitializeComponent();
        }
        
        private void AddJewDataControl_Load(object sender, EventArgs e)
        {
            SqliteHelper.Path  =  Environment.CurrentDirectory + "\\JewelData.db";
            
            int id = 0;
            
        }
        public void loadCreatorClass()
        {
            loadPeople();
            loadClass();
        }

        private void btn_addJewData_Click(object sender, EventArgs e)
        {
            if (!processSpec.IsConn)
                return;
            try
            {
                 List< double > realSign = new List<double>();
                List<double> unRealSign = new List<double>();
                for (int i=0;i<dgv_sign .Rows.Count;i++)
                {
                    double real, unReal;
                    if(double.TryParse (dgv_sign.Rows[i].Cells [0].Value .ToString (),out real ))
                    {
                        realSign.Add(real);
                    }
                    if(double.TryParse (dgv_sign .Rows [i].Cells [1].Value .ToString (),out unReal ))
                    {
                        unRealSign.Add(unReal);
                    }
                }

                JewDataClass jewSample = new JewDataClass();
                jewSample.jewId = processSpec.JewID;
                jewSample.jewName = txt_name.Text.Trim();
                jewSample.jewClass = cbx_class.SelectedItem.ToString();
                jewSample.wavelength = ProcessArray.getOneStepArrayDouble(processSpec.ShowWavelength_MinMax[0], processSpec.ShowWavelength_MinMax[1]);
                jewSample.spectrum = ProcessArray.FixArrayY(jewSample.wavelength, processSpec.wavelengths, processSpec.showY);
                jewSample.creator = cbx_people.SelectedItem.ToString();
                jewSample.remark = rtb_remark.Text.Trim();
                jewSample.addTime = DateTime.Now.ToString();
                jewSample.realSign = realSign;
                jewSample.unRealSign = unRealSign;

                SqliteHelper.SaveJewData(jewSample);
                processSpec.JewID = processSpec.JewID + 1;
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败！" + ex.Message);
            }
            
        }



        private void loadPeople()
        {
            cbx_people.Items.Clear();
            string str = "SELECT Name FROM CreatorTable";
            DataTable peopleName =SqliteHelper.ExecDataTable(str);
            foreach (DataRow dr in peopleName.Rows)
            {
                cbx_people.Items.Add(dr["Name"]);
            }
            if (cbx_people.Items.Count > 0)
            {
                cbx_people.SelectedIndex = 0;
            }

        }
        private void loadClass()
        {
            cbx_class.Items.Clear();
            string str = "SELECT Name FROM ClassTable";
            //List<object >strname=SqliteHelper.ExecObject(str);
            DataTable className = SqliteHelper.ExecDataTable(str);
            foreach (DataRow dr in className.Rows)
                //foreach (object obj in strname )
            {
                cbx_class.Items.Add(dr["Name"]);
            }
            if (cbx_class.Items.Count > 0)
            {
                cbx_class.SelectedIndex = 0;
            }
        }

        private void btn_classManager_Click(object sender, EventArgs e)
        {
            ClassManager classManag = new ClassManager();
            classManag.Onrefresh +=new ClassManager.RefreshHander ( loadClass);
            classManag.ShowDialog ();
        }

        private void btn_peopleManager_Click(object sender, EventArgs e)
        {
            PeopleManager peopleManag = new PeopleManager();
            peopleManag.onRefresh += new PeopleManager.refreshHander(loadPeople);
            peopleManag.ShowDialog();
        }

        private void 添加行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_sign.Rows.Add();
        }

        private void 删除行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgv_sign.CurrentCell!=null)
            dgv_sign.Rows.RemoveAt(dgv_sign.CurrentCell.RowIndex);
        }
    }
}
