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

        private void button8_Click(object sender, EventArgs e) // ADD BUTTON 
        {
            string cn = cbcn.Text;
            string ci = cbi.Text;


            int quantity = Convert.ToInt32(Math.Round(numericUpDownquan.Value, 0));
            Thread.Sleep(quantity);


            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(cbcn.Text) && !string.IsNullOrEmpty(cbi.Text) && numericUpDownquan.Value == 0)
            {
                if (Convert.ToString(comboBox1.Text).Equals("pay") && !string.IsNullOrEmpty(textBox1.Text))
                {

                    SqlConnection sqlc = new SqlConnection(cc.conn);


                



                    string quer2 = "INSERT INTO orders(product_id, quantity)VALUES ((SELECT product_id ,price FROM products WHERE product_name = '" + ci + "' ), @quantity)";
                    SqlCommand command2 = new SqlCommand(quer2, sqlc);

                   // command2.Parameters.AddWithValue("@product_id", );

                    command2.Parameters.AddWithValue("@quantity", quantity);

                    command2.ExecuteNonQuery();


                    int promo = Convert.ToInt32(numericUpDown3);

                    string quer3 = "insert into order_transaction (order_id,discount_id ,staff_id,,status,payment_method,transaction_date) values (@order_id,@discount_id ,@staff_id,@customer_id,@status,@payment_method,@transaction_date)";
                    SqlCommand command3 = new SqlCommand(quer3, sqlc);
                  
                  
                    command3.Parameters.AddWithValue("@order_id", drd1.Read());
                    command3.Parameters.AddWithValue("@discount_id", promo);


                    command3.ExecuteNonQuery();

                }
            }

        } // ADD BUTTON 


        public void seecustomers()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            try
            {
                string str = "SELECT CONCAT(first_name, ' ', last_name) AS 'Customer Name' FROM customer ";
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


            numericUpDownquan.ResetText();

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
                string st = "select order_id ,p.product_id ,p.product_name, quantity from orders AS o INNER JOIN products AS p ON p.product_id = o.product_id";
                SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                SqlCommand command = new SqlCommand();

                command.CommandText = st;
                command.Parameters.Clear();
                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


              

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}