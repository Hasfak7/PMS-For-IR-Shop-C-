using Pharmacy_Management_System.AdministratorUC;
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
    public partial class Adminstrator : Form
    {
        String user = "";
        public Adminstrator()
        {
            InitializeComponent();
            
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Adminstrator(String username)
        {
            InitializeComponent();
            label2.Text= username;
            user = username;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;

        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Profile1.Visible = false;

            uC_ViewUser1.Visible = false;
            

            uC_AddUser1.Visible = false;
            uC_Dashboard1.Visible = true;
            uC_AddUser1.Visible = false;
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = false;

            uC_ViewUser1.Visible = false;
            uC_Dashboard1.Visible = false;

            uC_AddUser1.Visible = false;

            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = false;

            uC_ViewUser1.Visible = false;
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = false;

           
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
         

            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = false;
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
        

            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();

        }
    }
}
