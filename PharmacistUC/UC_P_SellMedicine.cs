using DGVPrinterHelper;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select mname from medic where eDate >=getdate() and quantity>'0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select * from medic where mname like '" + guna2TextBox1.Text + "%' and eDate >=getdate() and quantity >'0' ";
             ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2TextBox6.Clear();
            String name =listBox1.GetItemText(listBox1.SelectedItem);  
            guna2TextBox3.Text=name;
            query= "Select mid,eDate,perUnit from medic where  mname='" + name + "'";
            ds = fn.getData(query);
            guna2TextBox2.Text = ds.Tables[0].Rows[0][0].ToString();//id

            guna2DateTimePicker1.Text = ds.Tables[0].Rows[0][1].ToString(); //exdate

            guna2TextBox4.Text = ds.Tables[0].Rows[0][2].ToString();  //priceperunit


        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            if(guna2TextBox5.Text != "")
            {
                Int64 unitPrice=Int64.Parse(guna2TextBox4.Text);
                Int64 noOfUnit = Int64.Parse(guna2TextBox5.Text);

                Int64 totalAmount = unitPrice*noOfUnit;

               guna2TextBox6.Text = totalAmount.ToString();



            }
            else
            {
                guna2TextBox6.Clear();
            }

        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2TextBox2.Text != "")
            {

                query = "Select quantity from medic where  mid='" + guna2TextBox2.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString()); //50
                newQuantity = quantity - Int64.Parse(guna2TextBox5.Text); //50-5

                if(newQuantity >= 0)
                {

                    n = guna2DataGridView1.Rows.Add();

                    guna2DataGridView1.Rows[n].Cells[0].Value = guna2TextBox2.Text;

                    guna2DataGridView1.Rows[n].Cells[1].Value = guna2TextBox3.Text;

                    guna2DataGridView1.Rows[n].Cells[2].Value = guna2DateTimePicker1.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = guna2TextBox4.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = guna2TextBox5.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = guna2TextBox6.Text;

                    totalAmount = totalAmount + int.Parse(guna2TextBox6.Text);
                    totalLabel.Text = "Rs." + totalAmount.ToString();

                    query = "update medic set  quantity='" + newQuantity + "' where mid='" + guna2Button2.Text + "'";
                    fn.setData(query, "Medicine Added.");

                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only"+quantity+" Left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicine_Load(this, null);




            }
            else
            {
                MessageBox.Show("Select Medicine First", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          

        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;

      

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId=guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }

            catch
            {

            }
        }

      

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {


                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);

                }

                catch
                {

                }

                finally
                {
                    query = "Select quantity from medic where  mid='" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "update medic set  quantity='" + newQuantity + "' where mid='" + valueId + "'";
                    fn.setData(query, "Medicine Removed from Cart. ");

                    totalAmount = totalAmount - valueAmount;
                    totalLabel.Text = "Rs." + totalAmount.ToString();

                }
                UC_P_SellMedicine_Load(this, null);

            }


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:-{0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment=StringAlignment.Near;
            print.Footer = "Total Payable Amount :" + totalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totalLabel.Text = "Rs. 00";
            guna2DataGridView1.DataSource = 0;



        }


        private void clearAll()
        {
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2DateTimePicker1.ResetText();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();


        }
    }
}
