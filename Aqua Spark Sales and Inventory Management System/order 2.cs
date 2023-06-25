﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class order_2 : Form
    {
        public order_2()
        {
            InitializeComponent();
            //  seeneworders();
            orderstatus();

        }
        connection_class cen = new connection_class();
        private void button1_Click(object sender, EventArgs e) // home button 
        {

            this.Hide();
            s.Hide();
            //  panel1.Hide();

        } // home button 



        selection s = new selection();
        private void button2_Click(object sender, EventArgs e)   // add button
        {

            // panel1.Show();


            //s.FormBorderStyle = FormBorderStyle.None;
            //s.TopLevel = false;
            //s.Dock = DockStyle.Fill;

            //s.AutoScroll = true;
            //   panel1.Controls.Add(s);

            s.Show();


        } // add button

        private void button3_Click(object sender, EventArgs e) // remove button
        {

            s.Hide();
            //    panel1.Hide();

        }// remove button



        public void seeneworders()
        {
            SqlConnection sqlconn = new SqlConnection(cen.conn);
            sqlconn.Open();
            //  string str = "select * from order_tansactions";
            string sj = "select CONCAT(c.first_name, c.last_name)AS 'full name' ,p.product_id,order_id ,product_name,quantity from customer AS c,products AS p INNER JOIN orders AS o on p.product_id = o.product_id";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlconn);
            DataTable table = new DataTable();

            data.Fill(table);

            //   dataGridView_order.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_sales.DataSource = table;


            sqlconn.Close();

        }


        public void delete()
        {

            try
            {



                using (SqlConnection cnn = new SqlConnection(cen.conn))
                {
                    cnn.Open();

                    int st = Convert.ToInt32(dataGridView_sales.Rows[0].Selected);

                    string inn = ("INSERT INTO deletedorders (order_id, product_id, quantity)SELECT* FROM orders WHERE order_id = " + st + "'");

                    SqlCommand command = new SqlCommand(inn, cnn);

                    command.ExecuteNonQuery();

                    //     string del = (" DELETE FROM NET WHERE id = '" + st + "'");
                    //   SqlCommand command1 = new SqlCommand(del, cnn);

                    //      command1.ExecuteNonQuery();

                    cnn.Close();


                }

            }
            catch
            {
                MessageBox.Show("Error ", " Error ", MessageBoxButtons.OK);
            }


        }

        private void button4_Click(object sender, EventArgs e)  // orders
        {


            if (comboBox1.Text == "existing")
            {
                see();
                dataGridView_sales.Refresh();
            }
            else if (comboBox1.Text == "removed")
            {
                seeremoved();
                dataGridView_sales.Refresh();
            }


        }  // orders

        public void orderstatus()
        {
            ArrayList clist = new ArrayList();

            clist.Add("existing");
            clist.Add("removed");

            foreach (string pos in clist)
            {
                comboBox1.Items.Add(pos);
            }

        }

        public void see()
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = "select order_id ,p.product_id ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id WHERE orderstatus = '1' ";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;




            }
        }
        public void seeremoved()
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = "select order_id ,p.product_id ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id WHERE orderstatus = '2' ";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;





            }
        }

        private void button5_Click(object sender, EventArgs e) // delivery button
        {

        }// delivery button
    }
}