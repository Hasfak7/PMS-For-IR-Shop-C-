﻿using System;
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
    public partial class UC_Dashboard : UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "Select count(userRole) from users where userRole='Administrator'";
            ds=fn.getData(query);
            setLabel(ds, label3);

            query = "Select count(userRole) from users where userRole='Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, label4);
        }

        private void setLabel(DataSet ds, Label ibl)
        {

            if(ds.Tables[0].Rows.Count != 0)
            {
              
                ibl.Text = ds.Tables[0].Rows[0][0].ToString(); 
                
                
            }
            else
            {
                ibl.Text = "0";
            }

        }


    }
}
