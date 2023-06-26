using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }
        connection_class cnn = new connection_class();

        Inventory_Wiindow iw = new Inventory_Wiindow();
        inventory2 i2 = new inventory2();
        private void button4_Click(object sender, EventArgs e)  // inventory window
        {

            panel1.Show();

            i2.Show();
            i2.FormBorderStyle = FormBorderStyle.None;
            i2.TopLevel = false;
            i2.Dock = DockStyle.Fill;

            i2.AutoScroll = true;
            panel1.Controls.Add(i2);

            i2.Show();
            a.Hide();
            o2.Hide();
            s2.Hide();


        }  // inventory window


        sales2 s2 = new sales2();
        private void button2_Click(object sender, EventArgs e) // sales window
        {

            s2.Show();
            panel1.Show();

            s2.Show();
            s2.FormBorderStyle = FormBorderStyle.None;
            s2.TopLevel = false;
            s2.Dock = DockStyle.Fill;

            o2.AutoScroll = true;
            panel1.Controls.Add(s2);


            o2.Hide();
            a.Hide();

        } // sales window


        private void button8_Click(object sender, EventArgs e)  // log out window
        {
            log_in_window lg = new log_in_window();
            lg.addlogout();

            panel1.Hide();


            if (button8logout != null)
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();

                su.Hide();
                iw.Hide();
                cw.Hide();
                o3.Hide();
                ow.Hide();
                // sw1.Hide();


                p.Hide();

                lg.addlogout();


            }
        } // log out window

        Orders_Window ow = new Orders_Window();
        order_2 o2 = new order_2();
        private void button1_Click(object sender, EventArgs e)  // orders window
        {
            panel1.Show();

            o2.Show();
            o2.FormBorderStyle = FormBorderStyle.None;
            o2.TopLevel = false;
            o2.Dock = DockStyle.Fill;

            o2.AutoScroll = true;
            panel1.Controls.Add(o2);


            o2.Show();
            a.Hide();
            s2.Hide();

        }  // orders window

        Customers_Window cw = new Customers_Window();
        customer2 c2 = new customer2();
        private void button3_Click(object sender, EventArgs e) // customers windows 
        {
            panel1.Show();

            c2.Show();
            c2.FormBorderStyle = FormBorderStyle.None;
            c2.TopLevel = false;
            c2.Dock = DockStyle.Fill;

            c2.AutoScroll = true;
            panel1.Controls.Add(c2);

            c2.Show();
            i2.Hide();
            o2.Hide();
            a.Hide();
            s2.Hide();

        } // customers windows 

        private void button5_Click(object sender, EventArgs e) // list button
        {
            //   listBox1.Show();
            //   dataGridView_main.Show();
            dataGridView1.Show();
            button12.Show();
            buttonpay.Hide();
            buttoncncel.Hide();
            // saleslist();
            //seelist();
            orderlist();
            panel1.Hide();
            p.Hide();
        }// list button

        payment py = new payment();
        order3 o3 = new order3();
        private void button6_Click(object sender, EventArgs e) // sell button
        {

            o3.Show();
            //py.Show();
            no.Hide();


            button12.Hide();
            //    listBox1.Hide();
            //    dataGridView_main.Hide();
            dataGridView1.Hide();
            panel1.Hide();
            p.Hide();

        }// sell button

        New_Order no = new New_Order();
        private void button7_Click(object sender, EventArgs e) // add order
        {

            no.Show();
            py.Hide();
            o3.Hide();
            button12.Hide();
            buttonpay.Hide();
            buttoncncel.Hide();
            //  listBox1.Hide();
            //    dataGridView_main.Hide();
            dataGridView1.Hide();
            panel1.Hide();
            p.Hide();
        }// add order

        private void button12_Click(object sender, EventArgs e) // x button list box
        {
            //listBox1.Hide();
            //   dataGridView_main.Hide();
            dataGridView1.Hide();
            button12.Hide();
            buttonpay.Hide();
            buttoncncel.Hide();

            panel1.Hide();
            p.Hide();
        }// x button list box



        private void button2minmize_Click(object sender, EventArgs e) // minimize button
        {
            button4inventory.Hide();
            button3customers.Hide();
            button2salesinfo.Hide();
            button1orders.Hide();
            button2minmize.Hide();
            pictureBox1.Hide();
            buttonemp.Hide();
            button2.Hide();

            button1.Show();
            su.Hide();
            iw.Hide();
            cw.Hide();
            o3.Hide();
            ow.Hide();

            button5.Show();
            button6.Show();
            button7.Show();
            button8logout.Show();
            dataGridView1.Hide();
            panel1.Hide();
            p.Hide();
            // dataGridView_main.Hide();
        } //minimimze button

        private void button1_Click_1(object sender, EventArgs e) // see more button
        {
            button4inventory.Show();
            button3customers.Show();
            button2salesinfo.Show();
            button1orders.Show();
            button2minmize.Show();
            pictureBox1.Show();
            buttonemp.Show();
            button2.Show();
            o3.Hide();
            button1.Hide();
            panel1.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8logout.Hide();
            dataGridView1.Hide();
            p.Hide();
            // dataGridView_main.Hide();
        }// see more button


        sign_up su = new sign_up();
        private void button2_Click_1(object sender, EventArgs e)// employee button
        {

            su.Show();
            panel1.Hide();

        } // employee button


        public void saleslist()
        {
            SqlConnection conect = new SqlConnection(cnn.conn);
            try
            {
                conect.Open();
                string list = "select * from products";
                SqlDataAdapter data = new SqlDataAdapter(list, conect);
                DataTable table = new DataTable();

                data.Fill(table);

                //  dataGridView_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //  dataGridView_main.DataSource = table;


            }
            catch
            {
                MessageBox.Show("Error ", "something went wrong", MessageBoxButtons.OK);
            }

            finally
            {
                conect.Close();
            }
        }

        public void orderlist()
        {
            SqlConnection conect = new SqlConnection(cnn.conn);
            try
            {
                conect.Open();
                string list = "  SELECT p.product_id ,product_name,p.price,p.size ,o.order_id , o.quantity from products AS p left join orders AS o ON p.product_id = o.product_id";
                SqlDataAdapter data = new SqlDataAdapter(list, conect);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


            }
            catch
            {
                MessageBox.Show("Error ", "something went wrong", MessageBoxButtons.OK);
            }

            finally
            {
                conect.Close();
            }
        }
        sign_up a = new sign_up();
        private void button2_Click_2(object sender, EventArgs e) // emp button
        {
            panel1.Show();

            a.Show();
            a.FormBorderStyle = FormBorderStyle.None;
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;

            a.AutoScroll = true;
            panel1.Controls.Add(a);

            a.Show();
            o2.Hide();
            s2.Hide();



        }//emp button
        pay p = new pay();
        private void button3_Click_1(object sender, EventArgs e)
        {
            p.Show();
        }
    }
}


/*
  *                    SELECT i.inventory_id, p.product_id ,s.supplier_id, i.quantity ,i.date_added FROM inventory AS s,products AS p INNER JOIN inventory AS i on i.product_id = p.product_id;
use aquasparkdata;

SELECT o.product_id ,o.order_id , ot.order_transaction_id , o.quantity , ot.payment_method ,ot.transaction_date , ot.status AS 'product Status'
FROM orders AS o INNER JOIN order_transaction AS ot ON o.order_id = ot.order_id;

select * from products;

 p.product_name , p.price  ,
  products AS p ,

  SELECT p.product_id ,product_name,p.price,p.size ,o.order_id , o.quantity from products AS p left join orders AS o ON p.product_id = o.product_id ;
  

  select c.customer_id , first_name , last_name , address, ot.discount_id,ot.staff_id, ot.order_id,ot.payment_method,ot.transaction_date , ot.status , o.product_id , o.quantity
  from  orders AS o  , customer as c  left JOIN order_transaction AS ot ON ot.customer_id = c.customer_id  LEFT JOIN orders  ON  o.order_id = ot.order_id ;

  * 
  * 
  * 
  */
