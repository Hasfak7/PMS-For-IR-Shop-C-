using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {

        function fn = new function();
        String query;


        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guna2ComboBox1.SelectedIndex == 0)
            {
                query = "select * from medic where eDate>=getdate()";
                DataSet ds= fn.getData(query);
                guna2DataGridView1.DataSource=ds.Tables[0];
                label3.Text = "Valid Medicines. ";
                label3.ForeColor = Color.Black;
            }
            else if(guna2ComboBox1.SelectedIndex == 1)
            {
                query = "select * from medic where eDate<=getdate()";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Expired Medicines. ";
                label3.ForeColor = Color.Red; 
            }

            else if (guna2ComboBox1.SelectedIndex == 2)
            {
                query = "select * from medic";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                label3.Text = "";
                label3.ForeColor = Color.Black;
            }



        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
