using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;



        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text!="" && guna2TextBox2.Text != "" && guna2TextBox3.Text != "" && guna2DateTimePicker1.Text != "" &&  guna2DateTimePicker2.Text != "" && guna2TextBox4.Text != "" && guna2TextBox5.Text != "")
            {

                String mid=guna2TextBox1.Text;

                String mname = guna2TextBox2.Text;
                String mnumber = guna2TextBox3.Text;


                String mdate = guna2DateTimePicker1.Text;
                String edate = guna2DateTimePicker2.Text;
                
                Int64 quantity=Int64.Parse(guna2TextBox4.Text);
                Int64 perunit = Int64.Parse(guna2TextBox5.Text);
                query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values('" + mid + "', '" + mname + "', '" + mnumber + "', '" + mdate + "', '" + edate + "','" + quantity + "','" + perunit + "')";
                fn.setData(query, "Medicine Added to Database.");



         

            }
            else
            {
                MessageBox.Show("Enter All Data Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
