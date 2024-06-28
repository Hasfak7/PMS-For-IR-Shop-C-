using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {

        function fn = new function();
        String query;


        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
   
            String role = comboBox1.Text;
            String name = textBox1.Text;
            String dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(textBox2.Text);

            String email = textBox3.Text;
            String username = textBox4.Text;
            String pass = textBox5.Text;
            
            try
            {
                query ="insert into users (userRole,name,dob,mobile,email,username,pass) values('" +role+ "', '"+name+"', '"+dob+"', '"+mobile+"', '"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Sing Up Successful.");


            }

            catch (Exception)
            {
                MessageBox.Show("User Name Allready exist. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + textBox4.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {

                pictureBox1.ImageLocation = @"C:\\Users\\BSC\\Desktop\\C# Pharmacy Management System\\Pharmacy Management System in C#\yes.png";


            }
            else
            {

                pictureBox1.ImageLocation = @"C:\\Users\\BSC\\Desktop\\C# Pharmacy Management System\\Pharmacy Management System in C#\no.png";

            }

        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
