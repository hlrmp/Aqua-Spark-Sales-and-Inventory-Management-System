using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class order3 : Form
    {
        public order3()
        {
            InitializeComponent();
            seecustomers();
            seeitems();
        }

        connection_class cc = new connection_class();

        private void button8_Click(object sender, EventArgs e) // ADD BUTTON 
        {
            string cn = cbcn.Text;
            string ci = cbi.Text;

            int quantity = Convert.ToInt32(numericUpDownquan);



        } // ADD BUTTON 


        public void seecustomers()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            try
            {
                string str = "SELECT CONCAT(first_name, ' ', last_name) AS 'Customer Name' FROM customer ";
                SqlCommand cmd = new SqlCommand(str, sqlc);
                cmd.CommandText = str;
                sqlc.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    cbcn.Items.Add(drd["Customer Name"].ToString());

                }
            }
            catch
            {
                MessageBox.Show(" something went wrong ", "Error ", MessageBoxButtons.OK);   // running without using 
            }

            finally
            {
                sqlc.Close();
            }
        }



        public void seeitems()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            try
            {
                string str = "select product_name from products";
                SqlCommand cmd = new SqlCommand(str, sqlc);
                cmd.CommandText = str;
                sqlc.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    cbi.Items.Add(drd["product_name"].ToString());


                }
            }
            catch
            {
                MessageBox.Show("Error ", " Error ", MessageBoxButtons.OK);
            }

            finally
            {
                sqlc.Close();
            }
        }



        private void button1_Click_1(object sender, EventArgs e)//  cancell   button
        {

            this.Hide();


        }//  cancell   button

        private void button9_Click(object sender, EventArgs e)//clear button
        {


            numericUpDownquan.ResetText();

            dataGridView1.Refresh();


        }// clear button







        calcu cu = new calcu();
        private void button3_Click(object sender, EventArgs e)
        {
            cu.Show();


        }
    }
}