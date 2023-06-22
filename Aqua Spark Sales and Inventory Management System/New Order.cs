using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Data.SqlTypes;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class New_Order : Form
    {
        public New_Order()
        {
            InitializeComponent();

            see();
        }
        connection_class cc = new connection_class();





        private int orderid;
        private int ordertransaactionid;
        private int discountid;
        private int customerid;
        private int staffid;
        private string status;
        private double payment;
        private double price;
        private double total_price;
        private int quantity;
        private string customer_address;
        private string customer_number;
        private string customer_email;
        private string fname;
        private string lname;

        public New_Order(string ln, string fn, string add, string cnum, string em)
        {
            this.lname = ln;
            this.fname = fn;
            this.customer_address = add;
            this.customer_number = cnum;
            this.customer_email = em;
            this.quantity = 0;
            this.pay = 0.0;
            this.total_price = 0.0;

        }
        public string firstname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string lastname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string address
        {
            get { return customer_address; }
            set { customer_address = value; }
        }
        public string number
        {
            get { return customer_number; }
            set { customer_number = value; }
        }
        public string email
        {
            get { return customer_email; }
            set { customer_email = value; }
        }
        public int quanti
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double pay
        {
            get { return pay; }
            set { pay = value; }
        }
        public double totlalamount
        {
            get { return total_price; }
            set { total_price = value; }
        }

        private void button1_Click(object sender, EventArgs e)  // cancel button
        {
            textBox1.Clear();
            textBoxl.Clear();
            textBox3.Clear();

            this.Hide();
        }// cancel button

        private void button3_Click(object sender, EventArgs e) // clear button
        {
            textBox1.Clear();
            textBoxl.Clear();
            textBox3.Clear();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();


        } // clear button

        private void button2_Click(object sender, EventArgs e) // add button
        {




            fname = textBoxf.Text;
            lname = textBoxl.Text;
            customer_address = textBox3.Text;
            customer_number = textBox1.Text;
            customer_email = textBoxe.Text;

            quantity = (int)numericUpDown1.Value;
            pay = (double)numericUpDown2.Value;
            total_price = (double)numericUpDown3.Value;
            SqlDateTime dt = new SqlDateTime();
            string day = DateTime.Now.ToString("M/d/yyyy");


        } // add button

        public void add()
        {

            try
            {



                using (SqlConnection cnn = new SqlConnection(cc.conn))
                {

                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cnn.Open();
                        string day = DateTime.Now.ToString("M/d/yyyy");
                        string quer1 = "INSERT INTO customer(first_name,last_name,address,contact_number,email)values(@first_name,@last_name,@address,@contact_number,@email)";
                        SqlCommand command = new SqlCommand(quer1, cnn);

                        command.Parameters.AddWithValue("@first_name", textBoxf.Text);
                        command.Parameters.AddWithValue("@last_name", textBoxl.Text);
                        command.Parameters.AddWithValue("@address", textBox3.Text);
                        command.Parameters.AddWithValue("@contact_number", textBox1.Text);
                        command.Parameters.AddWithValue("@email", textBoxe.Text);
                        command.ExecuteNonQuery();




                    }
                    else
                    {
                        MessageBox.Show(" fill up the ff.");
                    }


                    cnn.Close();


                }


            }
            catch
            {
                MessageBox.Show("Error ");
            }




        }

        public void see()
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
                    comboBox1.Items.Add(drd["product_name"].ToString());


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


        public void inserttransaction()
        {

            try
            {



                using (SqlConnection cnn = new SqlConnection(cc.conn))
                {

                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cnn.Open();

                        string day = DateTime.Now.ToString("M/d/yyyy");

                        string quer1 = "  INSERT INTO customer (first_name ,last_name,address,contact_number,email ) VALUES (@first_name ,@last_name,@address,@contact_number,@email)";
                        SqlCommand command = new SqlCommand(quer1, cnn);

                        command.Parameters.AddWithValue("@first_name", textBoxf.Text);
                        command.Parameters.AddWithValue("@last_name", textBoxl.Text);
                        command.Parameters.AddWithValue("@address", textBox3.Text);
                        command.Parameters.AddWithValue("@contact_number", textBox1.Text);
                        command.Parameters.AddWithValue("@contact_number", textBoxe.Text);
                        command.ExecuteNonQuery();


                        SqlConnection sqlc = new SqlConnection(cc.conn);

                        string n = comboBox1.Text;
                        string st = " SELECT product_id FROM products WHERE product_name = '" + n + "' ";
                        SqlCommand cmd1 = new SqlCommand(st, sqlc);
                        cmd1.CommandText = st;
                        sqlc.Open();
                        SqlDataReader drd1 = cmd1.ExecuteReader();



                        string quer2 = "INSERT INTO orders(product_id, quantity)VALUE (@product_id, @quantity);";
                        SqlCommand command2 = new SqlCommand(quer2, cnn);

                        command2.Parameters.AddWithValue("@product_id", drd1.Read());
                        command2.Parameters.AddWithValue("@quantity", quantity);

                        command2.ExecuteNonQuery();


                        int promo = Convert.ToInt32(numericUpDown3);

                        string quer3 = "insert into order_transaction (order_id,discount_id ,staff_id,,status,payment_method,transaction_date) values (@order_id,@discount_id ,@staff_id,@customer_id,@status,@payment_method,@transaction_date)";
                        SqlCommand command3 = new SqlCommand(quer3, cnn);
                        SqlDataReader drd = cmd1.ExecuteReader();

                        command3.Parameters.AddWithValue("@order_id", drd1.Read());
                        command3.Parameters.AddWithValue("@discount_id",promo );
                        command3.Parameters.AddWithValue("@staff_id", drd1.Read());
                        command3.Parameters.AddWithValue("@customer_id", promo);

                        command3.ExecuteNonQuery();


                    }
                    else
                    {
                        MessageBox.Show(" fill up the ff.");
                    }




                    cnn.Close();


                }






            }
            catch
            {
                MessageBox.Show("Error ");
            }




        }

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



    }
}
