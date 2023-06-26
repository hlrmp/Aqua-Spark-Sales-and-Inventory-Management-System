using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class pay : Form
    {
        public pay()
        {
            InitializeComponent();
            seecustomers();
            see();
            paymentterms();

        }
        connection_class cc = new connection_class();
     

        public void seecustomers()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);

            string str = " SELECT customer_id, CONCAT(first_name, ' ', last_name) AS 'Customer Name'  FROM customer ";
            SqlCommand cmd = new SqlCommand(str, sqlc);
            cmd.CommandText = str;
            sqlc.Open();
            SqlDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                cbcn.Items.Add(drd["Customer Name"].ToString());

            }


            sqlc.Close();
        }



        public void see()
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = "select CONCAT(first_name, ' ', last_name) AS 'Customer Name', product_id , quantity from customer as c inner join order_transaction as ot ON c.customer_id = ot.customer_id inner join orders as o ON ot.order_id = o.order_id where o.orderstatus = '1'";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;

                dataGridView1.Refresh();



            }
        }
        public void paid()
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = "select CONCAT(first_name, ' ', last_name) AS 'Customer Name', product_id , quantity from customer as c inner join order_transaction as ot ON c.customer_id = ot.customer_id inner join orders as o ON ot.order_id = o.order_id where o.orderstatus = '2'";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;

                dataGridView1.Refresh();



            }
        }
        public void paymentterms()
        {
            ArrayList clist = new ArrayList();

            clist.Add("paid");
            clist.Add("pending");

            foreach (string pos in clist)
            {
                comboBox2.Items.Add(pos);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "paid")
            {
                paid();
                dataGridView1.Refresh();

            }
            else if (comboBox2.Text == "pending")
            {
                see();
                dataGridView1.Refresh();
            }

        }
        double price;
        double quan;
        double total;
        double payment;
        double change;

        private void cbcn_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);

            string st = "select quantity from customer as c inner join order_transaction as ot ON c.customer_id = ot.customer_id inner join orders as o ON ot.order_id = o.order_id where c.customer_id = (SELECT customer_id FROM customer where CONCAT(first_name, ' ', last_name)   = '" + cbcn.Text + "')";
            SqlCommand cmd1 = new SqlCommand(st, sqlc);
            cmd1.CommandText = st;
            sqlc.Open();
            SqlDataReader drd1 = cmd1.ExecuteReader();
            drd1.Read();

            quan = Convert.ToDouble(drd1[0]);



            sqlc.Close();



            string st1 = "select price from products where product_id = (select product_id from customer as c inner join order_transaction as ot ON c.customer_id = ot.customer_id inner join orders as o ON ot.order_id = o.order_id where c.customer_id = (SELECT customer_id FROM customer where CONCAT(first_name, ' ', last_name)   = '" + cbcn.Text + "'))";
            SqlCommand cmd = new SqlCommand(st1, sqlc);
            cmd1.CommandText = st;
            sqlc.Open();
            SqlDataReader drd = cmd.ExecuteReader();
            drd.Read();

            price = Convert.ToDouble(drd[0]);



            sqlc.Close();

            total = price * quan;

            label1.Text = Convert.ToString(price);

            label9.Text = Convert.ToString(quan);

            label4.Text = Convert.ToString(total);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            payment = Convert.ToDouble(textBox1.Text);

            change = payment - total;
            
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if(payment >= total)
                {
                    MessageBox.Show(" " + "\n" +
                                  "quantity: " + quan + "\n" +
                                  "price:" + price + "\n" +
                                  "total pice: " + total + "\n" +
                                  "change: " + change + " " + " \n "
                                  , " payment ", MessageBoxButtons.OK);

                    paid();
                    dataGridView1.Refresh();

                    SqlConnection cn = new SqlConnection(cc.conn);
                    cn.Open();

                    string quer3 = "UPDATE order_transaction SET status = 1 WHERE order_transaction_id = (select order_transaction_id from order_transaction where order_transaction_id = (select max(order_transaction_id) from order_transaction) )";

                    SqlCommand command = new SqlCommand(quer3, cn);
                    command.ExecuteNonQuery();


                    cn.Close();


                }
                else
                {
                    MessageBox.Show("please input the right amount to procede");
                }
            }
            else
            {

            }
        }
    }
}
