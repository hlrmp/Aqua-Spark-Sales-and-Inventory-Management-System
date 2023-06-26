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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class customer2 : Form
    {
        public customer2()
        {
            InitializeComponent();
            seecustomers();
        }
        // 1 encapsulation customer info
        connection_class cc = new connection_class();

        private void button1_Click(object sender, EventArgs e) // home button 
        {

            this.Hide();

            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();


        }// home button 

        public void seecustomers()
        {
            SqlConnection sqlcc = new SqlConnection(cc.conn);
            try
            {
                /*
                string str = "select product_name from products";
                SqlCommand cmd = new SqlCommand(str, sqlcc);

                */
                string sj = "select customer_id , first_name,last_name,address,contact_number,email from customer where status = 1";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                //   dataGridView_order.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView_sales.DataSource = table;


            }
            catch
            {
                MessageBox.Show(" something went wrong ");
            }

            finally
            {
                sqlcc.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seecustomers();

            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();

        }



        new_customer nw = new new_customer();
        private void button2_Click(object sender, EventArgs e)
        {
            nw.Show();

            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();

            SqlConnection sqlcc = new SqlConnection(cc.conn);


            /*
            string str = "select product_name from products";
            SqlCommand cmd = new SqlCommand(str, sqlcc);

            */
            string sj = "select c.customer_id , first_name,last_name,address,contact_number,email ,order_id from customer AS c inner join order_transaction  as ot ON c.customer_id = ot.customer_id where c.status = '1'\r\n";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            //   dataGridView_order.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_sales.DataSource = table;
        }



        private void button8_Click(object sender, EventArgs e)
        {

            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            textBox2.Clear();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = " UPDATE customer SET status = 2 WHERE customer_id =  '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();

                seecustomers();
                dataGridView_sales.Refresh();

            } // delete button
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = " UPDATE customer SET status = 1 WHERE customer_id =  '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();

                seecustomers();
                dataGridView_sales.Refresh();

            } // undo button
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            pictureBox1.Show();

        }
    }
}
