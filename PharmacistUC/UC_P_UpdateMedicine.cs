using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;


        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                query = "select *from medic where mid='" + guna2TextBox1.Text + "'";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    guna2TextBox2.Text = ds.Tables[0].Rows[0][2].ToString();
                    guna2TextBox3.Text = ds.Tables[0].Rows[0][3].ToString();
                    guna2DateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
                    guna2DateTimePicker2.Text = ds.Tables[0].Rows[0][5].ToString();
                    guna2TextBox4.Text = ds.Tables[0].Rows[0][6].ToString();
                    guna2TextBox5.Text = ds.Tables[0].Rows[0][7].ToString();
                   



                }
                else
                {
                    MessageBox.Show("No Medicine with ID: "+guna2TextBox1.Text+" exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //clear textboxs

            }



        }
        Int64 totalQuantity;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String mname = guna2TextBox2.Text;
            String mnumber = guna2TextBox3.Text;


            String mdate = guna2DateTimePicker1.Text;
            String edate = guna2DateTimePicker2.Text;

            Int64 quantity = Int64.Parse(guna2TextBox4.Text);
            Int64 addQuantity = Int64.Parse(guna2TextBox6.Text);
            Int64 unitprice = Int64.Parse(guna2TextBox5.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medic set  mname='" + mname + "',mnumber='" + mnumber + "',mdate='" + mdate + "',edate='" + edate + "',quantity=" + totalQuantity + ",perUnit="+ unitprice +" where mid='"+guna2TextBox1.Text+"'" ;
            fn.setData(query, "Medicine Details Updates.");
        }
    }
}
