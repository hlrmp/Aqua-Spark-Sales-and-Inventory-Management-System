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
    public partial class sales2 : Form
    {
        public sales2()
        {
            InitializeComponent();
            see();
        }
        connection_class cnn = new connection_class();
        private void button1_Click(object sender, EventArgs e) // home button
        {
         
            this.Hide();

        }// home button

        private void button4_Click(object sender, EventArgs e)  // TOTAL SALES BUTTON
        {
            see();

        }// TOTAL SALES BUTTON



        public void see()
        {
            using (SqlConnection cn = new SqlConnection(cnn.conn))
            {




                cn.Open();
                string st = "select order_transaction_id,o.order_id ,discount_id,staff_id,concat(c.first_name ,' ',c.last_name) as 'Customer name', transaction_date ,p.product_name ,quantity from order_transaction as ot inner join orders AS o on o.order_id = ot.order_id  inner join customer as c ON  c.customer_id = ot.customer_id inner join products AS p ON p.product_id = o.product_id\r\n";
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



        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnn.conn))
            {

                cn.Open();
                string st = "select order_transaction_id,o.order_id ,discount_id,staff_id,concat(c.first_name ,' ',c.last_name) as 'Customer name', transaction_date ,p.product_name ,quantity from order_transaction as ot inner join orders AS o on o.order_id = ot.order_id  inner join customer as c ON  c.customer_id = ot.customer_id inner join products AS p ON p.product_id = o.product_id where status = '1'";

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

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnn.conn))
            {


                cn.Open();
                string st = "select order_transaction_id,o.order_id ,discount_id,staff_id,concat(c.first_name ,' ',c.last_name) as 'Customer name', transaction_date ,p.product_name ,quantity from order_transaction as ot inner join orders AS o on o.order_id = ot.order_id  inner join customer as c ON  c.customer_id = ot.customer_id inner join products AS p ON p.product_id = o.product_id where status = '2'\r\n ";
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
    }
}
