using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class Customers_Window : Form
    {
        public Customers_Window()
        {
            InitializeComponent();
            seecustomers();
        }
        connection_class css = new connection_class();

        private void button1_Click(object sender, EventArgs e)  // HOME WINDOWS
        {
            main_window mw1 = new main_window();
            mw1.Show();
            this.Hide();

        }  // HOME WINDOWS

        private void button2_Click(object sender, EventArgs e) // add customer
        {
            new_customer nc = new new_customer();
            nc.Show();

        }// add customer

        public void seecustomers()
        {
            SqlConnection sqlcc = new SqlConnection(css.conn);
            try
            {
                /*
                string str = "select product_name from products";
                SqlCommand cmd = new SqlCommand(str, sqlcc);

                */
                string sj = "select * from customer";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                //   dataGridView_order.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView_customers.DataSource = table;


            }
            catch
            {
                MessageBox.Show("Error ");
            }

            finally
            {
                sqlcc.Close();
            }
        }
    }
}
