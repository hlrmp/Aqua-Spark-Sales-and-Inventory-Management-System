using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class Inventory_Wiindow : Form
    {
        public Inventory_Wiindow()
        {
            InitializeComponent();
            invent();
        }
        connection_class ccs = new connection_class();
        private void button1_Click(object sender, EventArgs e)  // HOME
        {
            main_window mw = new main_window();
            mw.Show();
            this.Hide();
        } // HOME


        public void list()
        {
            ArrayList clist = new ArrayList();

            clist.Add(" ");

            clist.Add(" cashier ");

            foreach (string pos in clist)
            {
               
            }

        }


        public void invent()
        {
            using (SqlConnection cn = new SqlConnection(ccs.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT i.inventory_id, p.product_id , i.quantity ,i.date_added FROM inventory AS s,products AS p INNER JOIN inventory AS i on i.product_id = p.product_id";
                    ;
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_inventory.DataSource = table;



                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }



        }
        public void daily()
        {
            using (SqlConnection cn = new SqlConnection(ccs.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT * FROM order_transaction WHERE DATEDIFF(ww,  transaction_date , GETDATE()) = 0";
                    ;
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_inventory.DataSource = table;



                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }



        }


        public void monthly()
        {
            using (SqlConnection cn = new SqlConnection(ccs.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT * FROM order_transaction WHERE DATEDIFF(mm,  transaction_date , GETDATE()) = 0";
                    ;
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_inventory.DataSource = table;



                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }



        }

        public void yearly()
        {
            using (SqlConnection cn = new SqlConnection(ccs.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT * FROM order_transaction WHERE DATEDIFF(yy,  transaction_date , GETDATE()) = 0";
                    ;
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_inventory.DataSource = table;



                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }
        }

        private void button2_Click(object sender, EventArgs e)//daily button
        {
            daily();

        }// daily button

        private void button3_Click(object sender, EventArgs e) // monthly button

        {
            yearly();
        } // monthly button

        private void pictureBox2_Click(object sender, EventArgs e) // yearly button
        {
            yearly();
        }// yearly button

        private void button4_Click(object sender, EventArgs e)
        {

            monthly();
        }
    }
}
