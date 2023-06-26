using System;
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
            deliverystatus();
            seeor();

        }
        connection_class cen = new connection_class();
        private void button1_Click(object sender, EventArgs e) // home button 
        {

            this.Hide();
            s.Hide();
            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
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
            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

        } // add button

        private void button3_Click(object sender, EventArgs e) // remove button
        {

            s.Hide();
            //    panel1.Hide();


            textBox2.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            pictureBox1.Show();

            dataGridView_sales.Refresh();

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

            comboBox1.Show();
            comboBox2.Hide();
            s.Hide();
            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

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

        public void deliverystatus()
        {
            ArrayList clist = new ArrayList();

            clist.Add("delivered");
            clist.Add("for delivery");

            foreach (string pos in clist)
            {
                comboBox2.Items.Add(pos);
            }

        }
        public void seeor()
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = "select order_id  ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id WHERE orderstatus = 1  order by order_id DESC";
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

        public void see()
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = "select order_id ,o.product_id ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id WHERE orderstatus = 1  order by order_id DESC";
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
                string st = "select order_id ,o.product_id ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id WHERE orderstatus = 2  order by order_id DESC";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;


                cn.Close();


            }
        }

        private void button5_Click(object sender, EventArgs e) // delivery button
        {
            delivery();

            comboBox2.Show();
            comboBox1.Hide();
            s.Hide();
            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

        }// delivery button

        public void delivery()
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = "  select delivery_id  , address , CONCAT(first_name, ' ', last_name) AS 'Customer_Name',ot.payment_method, order_transaction_id , delivery_date  from   delivery AS d  INNER JOIN order_transaction AS ot  ON  d.order_transacton_id = ot.order_transaction_id INNER JOIN  customer AS c ON  d.costumer_id = c.customer_id where delivery_status = 1 order by delivery_id DESC\r\n";
                SqlCommand command = new SqlCommand();
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;


                cn.Close();


            }
        }
        public void delivered()
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = "  select delivery_id  , address , CONCAT(first_name, ' ', last_name) AS 'Customer_Name',ot.payment_method, order_transaction_id , delivery_date  from   delivery AS d  INNER JOIN order_transaction AS ot  ON  d.order_transacton_id = ot.order_transaction_id INNER JOIN  customer AS c ON  d.costumer_id = c.customer_id where delivery_status = 2 order by delivery_id DESC\r\n";
                SqlCommand command = new SqlCommand();
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.DataSource = table;


                cn.Close();


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "for delivery")
            {
                delivery();
                dataGridView_sales.Refresh();

            }
            else if (comboBox2.Text == "delivered")
            {
                delivered();
                dataGridView_sales.Refresh();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            textBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
        }

        private void button7_Click(object sender, EventArgs e) // delete button
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = " UPDATE orders SET orderstatus = '2' WHERE order_id = '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();
                dataGridView_sales.Refresh();
            } // delete button


        }

        private void button6_Click(object sender, EventArgs e) // undo button
        {
            using (SqlConnection cn = new SqlConnection(cen.conn))
            {


                cn.Open();
                string st = " UPDATE orders SET orderstatus = '1' WHERE order_id = '" + textBox2.Text + "' ";
                SqlCommand command = new SqlCommand(st, cn);
                command.ExecuteNonQuery();

                cn.Close();
                dataGridView_sales.Refresh();
            }
        }// undo button
    }
}