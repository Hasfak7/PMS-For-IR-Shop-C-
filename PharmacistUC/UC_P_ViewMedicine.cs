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

    public partial class UC_P_ViewMedicine : UserControl
    {

        function fn = new function();
        String query;
        public UC_P_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            DataSet ds = fn.getData(query);
           guna2DataGridView1.DataSource = ds.Tables[0];


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '"+guna2TextBox1.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
