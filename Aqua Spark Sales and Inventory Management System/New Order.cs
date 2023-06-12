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

        public New_Order(string ln , string fn , string add , string cnum , string em)
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
            set { fname = value;  }
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

        private void button2_Click(object sender, EventArgs e) // insert button
        {


        } // insert button


        public void see()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            try
{  
                string str = "select product_name from products";
                SqlCommand cmd = new SqlCommand(str , sqlc);
                cmd.CommandText = str;
                sqlc.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    comboBox1.Items.Add(drd["product_name"].ToString());

                    /*  comboBox1.ValueMember = drd["product_name"].ToString();
                      comboBox1.DisplayMember = drd["product_name"].ToString();
                     */
                }
            }
catch
{
                MessageBox.Show("Error ");
            }

            finally
            {
                sqlc.Close();
            }
        }


        /*
         public void newaddorder()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            sqlc.Open();
            string str = "select product_name from products";

            SqlDataAdapter d = new SqlDataAdapter(str, sqlc);
            DataTable t = new DataTable();

             d.Fill(t);
           
               
            
            ArrayList alist = new ArrayList
            {
                t
            };

            sqlc.Close();


            foreach (string it in alist)
            {
             
                    comboBox1.DataSource = dataSet1.Tables["Suppliers"];
                    comboBox1.DisplayMember = "ProductName";
               
                comboBox1.Items.Add(it);
            }

        }
         */

    }
}
