using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

            this.Hide();
            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();


        }  // HOME WINDOWS

        private void button2_Click(object sender, EventArgs e) // add customer
        {
            new_customer nc = new new_customer();
            nc.Show();

            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();

        }// add customer

        public void seecustomers()
        {
            SqlConnection sqlcc = new SqlConnection(css.conn);

            /*
            string str = "select product_name from products";
            SqlCommand cmd = new SqlCommand(str, sqlcc);

            */
            string sj = "select customer_id , first_name,last_name,address,contact_number,email from customer where status = 1";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            //   dataGridView_order.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_customers.DataSource = table;


            sqlcc.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox2.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            pictureBox1.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(css.conn))
            {


                cn.Open();
                string st = " UPDATE customer SET status = 1 WHERE customer_id =  '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();

                seecustomers();
                dataGridView_customers.Refresh();

            } // undo button
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(css.conn))
            {


                cn.Open();
                string st = " UPDATE customer SET status = 2 WHERE customer_id =  '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();

                seecustomers();
                dataGridView_customers.Refresh();

            } // delete button
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();
        }
    }
}
