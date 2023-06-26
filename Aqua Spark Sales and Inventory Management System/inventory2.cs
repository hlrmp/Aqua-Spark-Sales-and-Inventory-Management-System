using System;
using System.Collections;
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
    public partial class inventory2 : Form
    {
        public inventory2()
        {
            InitializeComponent();
            size();

        }
        connection_class c = new connection_class();
        private void button1_Click(object sender, EventArgs e) // home button
        {
           
            this.Hide();

        }// home button 

        public void newinvent()
        {
            using (SqlConnection cn = new SqlConnection(c.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT i.inventory_id, p.product_id , i.quantity ,i.date_added FROM inventory AS s,products AS p INNER JOIN inventory AS i on i.product_id = p.product_id";
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
                    MessageBox.Show("error", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }



        }

        private void button3_Click(object sender, EventArgs e) // product table 
        {
            products();

        }// product table


        public void products()
        {
            using (SqlConnection cn = new SqlConnection(c.conn))
            {




                cn.Open();
                string st = "SELECT * FROM products";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;



                cn.Close();

                // to close the connection


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(c.conn))
            {




                cn.Open();
                string st = "select SUM(product_id) AS 'transaction' , SUM(quantity) AS 'total product sell' from orders where orderstatus = 1";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;



                cn.Close();

                // to close the connection


            }


        }
        public void size()
        {
            ArrayList clist = new ArrayList();

            clist.Add("small");
            clist.Add("medium");
            clist.Add("large");

            foreach (string pos in clist)
            {
                comboBox1.Items.Add(pos);
            }

        }

        public void small()
        {
            using (SqlConnection cn = new SqlConnection(c.conn))
            {




                cn.Open();
                string st = "select SUM(product_id) AS 'transaction' , SUM(quantity) AS 'total product sell' from orders where orderstatus = 1 AND product_id = 1 ";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;



                cn.Close();

                // to close the connection


            }


        }
        public void medium()
        {
            using (SqlConnection cn = new SqlConnection(c.conn))
            {




                cn.Open();
                string st = "select SUM(product_id) AS 'transaction' , SUM(quantity) AS 'total product sell' from orders where orderstatus = 1 AND product_id = 2\r\n";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;



                cn.Close();

                // to close the connection


            }


        }

        public void large()
        {
            using (SqlConnection cn = new SqlConnection(c.conn))
            {




                cn.Open();
                string st = "select SUM(product_id) AS 'transaction' , SUM(quantity) AS 'total product sell' from orders where orderstatus = 1 AND product_id = 3\r\n";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;



                cn.Close();

                // to close the connection


            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "small")
            {
                small();
                dataGridView_sales.Refresh();

            }
            else if (comboBox1.Text == "medium")
            {
                medium();
                dataGridView_sales.Refresh();
            }
            else if (comboBox1.Text == "large")
            {
                large();
                dataGridView_sales.Refresh();
            }
        }
    }
}
