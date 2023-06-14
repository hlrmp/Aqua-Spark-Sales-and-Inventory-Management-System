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
            //  newaddorder();
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
            this.payment = 0.0;
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
            get { return payment; }
            set { payment = value; }
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
            numericUpDown3.ResetText();

        } // clear button

        private void button2_Click(object sender, EventArgs e) // add button
        {


            SqlConnection conect = new SqlConnection(cc.conn);
            try
            {

                fname = textBoxf.Text;
                lname = textBoxl.Text;
                customer_address = textBox3.Text;
                customer_number = textBox1.Text;
                customer_email = textBoxe.Text;

                quantity = (int)numericUpDown1.Value;
                payment = (double)numericUpDown2.Value;
                total_price = (double)numericUpDown3.Value;
                SqlDateTime dt = new SqlDateTime();


                string quer = " SELECT  customer_id FROM users WHERE first_name = '" + firstname + "'  AND last_name =  '" + lastname + "' ";
                string quer1 = " ";

                SqlCommand command = new SqlCommand();

                command = new SqlCommand(quer, conect);

                SqlDataReader reader = command.ExecuteReader();


                int quan = 10;

                for (int i = 10; quan > i; quan += 10)
                {

                }
                if (quantity >= 10 || quantity <= 20)
                {

                }


                conect.Open();



                command.ExecuteNonQuery();
                command.ExecuteScalar();
                conect.Close();





            }
            catch
            {
                MessageBox.Show("Error ", "something went wrong", MessageBoxButtons.OK);
            }

            finally
            {
                conect.Close();
            }

        } // add button



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

                        string quer1 = "  INSERT INTO customer (first_name ,last_name,address,contact_number,email ) VALUES (@first_name ,@last_name,@address,@contact_number,@email)";
                        SqlCommand command = new SqlCommand(quer1, cnn);

                        command.Parameters.AddWithValue("@first_name", textBoxf.Text);
                        command.Parameters.AddWithValue("@last_name", textBoxl.Text);
                        command.Parameters.AddWithValue("@address", textBox3.Text);
                        command.Parameters.AddWithValue("@contact_number", textBox1.Text);
                        command.Parameters.AddWithValue("@contact_number", textBoxe.Text);


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


    }
}
