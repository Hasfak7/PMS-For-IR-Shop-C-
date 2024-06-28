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

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;
      //  String currentUser = "";
        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { label7.Text = value; }
        }

       

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + label7.Text + "'";
            DataSet ds = fn.getData(query);
            comboBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox1.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox2.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string role = comboBox1.Text;
            string name = textBox1.Text;
            string dob = textBox2.Text;
            Int64 mobile = Int64.Parse(textBox3.Text);

            string email = textBox4.Text;
            string username = label7.Text;
            string pass = textBox5.Text;

            query = "update users set userRole ='" + role + "',name ='" + name + "',dob ='" + dob + "',mobile ='" + mobile + "',email ='" + email + "',pass ='" + pass + "' where username='" + username + "'";

            fn.setData(query, "Profile Updation Successful");
        }
    }
}
