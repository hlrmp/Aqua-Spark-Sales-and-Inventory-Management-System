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

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class Sales_window : Form
    {
        public Sales_window()
        {
            InitializeComponent();
        }
        connection_class noc = new connection_class();

        private void Sales_window_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_window mwd = new main_window();
            mwd.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)  // from order
        {
            orderswin();
        }// from order

        public void saleswindow()
        {
            using (SqlConnection cn = new SqlConnection(noc.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT * FROM order_transaction";
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_sales.DataSource = table;



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


        public void orderswin()
        {
            using (SqlConnection cn = new SqlConnection(noc.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT p.product_nmae, p.product_id , o.quantity ,o.order_id, transaction_date FROM order_transaction AS s,products AS p INNER JOIN orders AS o on p.product_id = o.product_id";
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_sales.DataSource = table;



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

        private void button4_Click(object sender, EventArgs e) // total sales
        {
            saleswindow();

        }//otal sales
    }
}