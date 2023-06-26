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
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
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
            paymentterms();
            see();
        }

        connection_class cc = new connection_class();
        int quantity;
        private void button8_Click(object sender, EventArgs e) // ADD BUTTON 
        {
            string cn = cbcn.Text;
            string ci = cbi.Text;


            quantity = Convert.ToInt32(Math.Round(numericUpDownquan.Value, 0));
            Thread.Sleep(quantity);

            if (button8 != null)
            {

                addorder();

              
            }
            else
            {

            }

        } // ADD BUTTON 

        double total;
        public void addorder()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            sqlc.Open();
            string quer2 = "INSERT INTO orders(product_id, quantity,orderstatus)VALUES ((SELECT product_id FROM products WHERE product_name = '" + cbi.Text + "' ), @quantity,@orderstatus)";
            SqlCommand command2 = new SqlCommand(quer2, sqlc);

            command2.Parameters.AddWithValue("@quantity", quantity);
            command2.Parameters.AddWithValue("@orderstatus", 1 );

            command2.ExecuteNonQuery();



          //  int promo = Convert.ToInt32(numericUpDown3);

            int promo = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
            Thread.Sleep(promo);

            string day = DateTime.Now.ToString("M/d/yyyy");

            log_in_window l = new log_in_window();


            string quer3 = "insert into order_transaction (order_id,discount_id ,staff_id,customer_id,status,payment_method,transaction_date) values (( select order_id from orders where order_id = (select max(order_id) from orders)),(select discount_id from discounts where discount_id  = '" + promo + "') ,(SELECT staff_id  FROM users as u INNER JOIN activity_logs AS c ON u.user_id = c.user_id where activity_id = (select max(activity_id) from activity_logs)),( SELECT customer_id FROM customer where CONCAT(first_name, ' ', last_name)   = '" + cbcn.Text + "'),@status,@payment_method,@transaction_date)";
            //  string quer3 = "insert into order_transaction (order_id,discount_id ,staff_id,customer_id,status,payment_method,transaction_date) values (( select order_id from orders where order_id = (select max(order_id) from orders)),( SELECT staff_id  FROM users as u INNER JOIN activity_logs AS c ON u.user_id = c.user_id where activity_id = (select max(activity_id) from activity_logs)),(select customer_id from customer where customer_id = (select max(customer_id) from customer)),@status,@payment_method,@transaction_date)";

            SqlCommand command3 = new SqlCommand(quer3, sqlc);


            //    command3.Parameters.AddWithValue("@order_id", drd1.Read());
            //  command3.Parameters.AddWithValue("@discount_id", promo);
            //  command3.Parameters.AddWithValue("@staff_id", );
            // command3.Parameters.AddWithValue("@customer_id", );
            command3.Parameters.AddWithValue("@status", " 2 ");  // #1 = pay
            command3.Parameters.AddWithValue("@payment_method", comboBox1.Text);
            command3.Parameters.AddWithValue("@transaction_date", day);

            command3.ExecuteNonQuery();

            sqlc.Close();

            string clickeddate = monthCalendar1.SelectionRange.Start.ToString("M/d/yyyy");

            string quer5 = "INSERT INTO delivery(order_transacton_id , costumer_id , delivery_status , delivery_date) values((select order_transaction_id from order_transaction where order_transaction_id = (select max(order_transaction_id) from order_transaction)) ,(select customer_id from order_transaction where order_transaction_id = (select max(order_transaction_id) from order_transaction)), 1, '" + clickeddate + "')";

            sqlc.Open();

            SqlCommand command5 = new SqlCommand(quer5, sqlc);

            command5.ExecuteNonQuery();



            sqlc.Close();



            string st = " SELECT price FROM products WHERE product_name = '" + cbi.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(st, sqlc);
            cmd1.CommandText = st;
            sqlc.Open();
            SqlDataReader drd1 = cmd1.ExecuteReader();
            drd1.Read();
            double price = Convert.ToDouble(drd1[0]);

            int count = Convert.ToInt32(Math.Round(numericUpDownquan.Value, 0));
            Thread.Sleep(count);


             total = price * count;

            label4.Text = Convert.ToString(total);

            sqlc.Close();
            
        }

        public void seecustomers()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            try
            {
                string str = " SELECT customer_id, CONCAT(first_name, ' ', last_name) AS 'Customer Name'  FROM customer ";
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

            textBox1.Clear();
            textBox2.Clear();
            numericUpDown3.ResetText();
            numericUpDownquan.ResetText();
            comboBox1.ResetText();
            cbcn.ResetText();
            cbi.ResetText();
            dataGridView1.Refresh();


        }// clear button





        public void paymentterms()
        {
            ArrayList clist = new ArrayList();

            clist.Add(" pay ");
            clist.Add(" pending payment ");

            foreach (string pos in clist)
            {
                comboBox1.Items.Add(pos);
            }

        }

        public void see()
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = "select order_id ,o.product_id ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id WHERE orderstatus = 1  order by order_id DESC";
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
        public void seeremoved()
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = "select order_id ,p.product_id ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id WHERE orderstatus = '2' order by order_id DESC";
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

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e) // existing order
        {
            dataGridView1.Refresh();
            see();
          

        } // existing order

        private void button5_Click(object sender, EventArgs e) // deleted order
        {
            dataGridView1.Refresh();
            seeremoved();

        }// deleted order

        private void button7_Click(object sender, EventArgs e) // delete button
        {

            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = " UPDATE orders SET orderstatus = '2' WHERE order_id = '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();

            }

        } // delete button

        private void button6_Click(object sender, EventArgs e) // undo button
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                cn.Open();
                string st = " UPDATE orders SET orderstatus = '1' WHERE order_id = '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();

            }

        }  // undo button

        private void button2_Click(object sender, EventArgs e) // pay
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                SqlConnection cn = new SqlConnection(cc.conn);
                cn.Open();

                string quer3 = " UPDATE order_transaction SET status = '1' WHERE status = '2' ";

                SqlCommand command = new SqlCommand(quer3, cn);
                command.ExecuteNonQuery();


                cn.Close();

                int pay = Convert.ToInt32(Math.Round(numericUpDownquan.Value, 0));
                Thread.Sleep(pay);

                if (pay > total)
                {
                    double change = pay - total;

                    MessageBox.Show(" " + "\n" +
                                    "payment: " + pay + "\n" +
                                    "total pice: " + total + "\n" +
                                    "change: " + change + " " + " \n "
                                    , " payment ", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(" input the right amount to pay ", " payment ", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show(" please input the payment ");
            }

          

        } // pay
    }
}