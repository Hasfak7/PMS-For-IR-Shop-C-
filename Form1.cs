using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {

        function fn = new function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            query = "select *  from users";
             ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count != 0)
            {

                if(textBox1.Text=="root" && textBox2.Text == "root")
                {
                    Adminstrator admin=new Adminstrator();
                    admin.Show();
                    this.Hide();

                }

                else
                {
                    query = "select * from users where username ='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
                    ds = fn.getData(query); 
                    if(ds.Tables[0].Rows.Count!= 0)
                    {
                        String role = ds.Tables[0].Rows[0][1].ToString();

                        if (role == "Administrator")
                        {
                            Adminstrator admin = new Adminstrator(textBox1.Text);
                            admin.Show();
                            this.Hide();
                        }
                        else if (role == "Pharmacist")
                        {
                           
                            Pharmacist pharm = new Pharmacist(textBox1.Text);
                            pharm.Show();
                            this.Hide();
                        }

                        
                        
                    }

                }


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
