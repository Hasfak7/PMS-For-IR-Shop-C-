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
    public partial class UC_StockCheck : UserControl
    {

        function fn = new function();
        String query;
        public UC_StockCheck()
        {
            InitializeComponent();
        }

        private void UC_StockCheck_Load(object sender, EventArgs e)
        {
            query = "select * from medic where quantity<5";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
