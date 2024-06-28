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

    public partial class Pharmacist : Form
    {

        String user = "";
        public Pharmacist()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Pharmacist(String username)
        {
            InitializeComponent();
            label2.Text = username;
            user = username;
          

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {

            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
            uC_P_AddMedicine1.Visible = false;
           
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            uC_StockCheck1.Visible = false;


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            uC_P_Dashboard1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            //   uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();

           
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = false;
            uC_P_Dashboard1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;


            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();


           

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {


            uC_P_AddMedicine1.Visible = false;
            uC_P_Dashboard1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;


            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();

            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = false;
            uC_P_Dashboard1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_SellMedicine1.Visible = false;


            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();

          
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            uC_P_AddMedicine1.Visible = false;
            uC_P_Dashboard1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;

            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();

            
          
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = false;
            uC_P_Dashboard1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = false;
            uC_P_Dashboard1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;

            uC_StockCheck1.Visible = true;
            uC_StockCheck1.BringToFront();


        }
    }
}
