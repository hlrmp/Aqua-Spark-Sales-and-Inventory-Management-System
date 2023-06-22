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

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class Home_window : Form
    {
        public Home_window()
        {
            InitializeComponent();
        }
        connection_class css = new connection_class();
        private void button5_Click(object sender, EventArgs e) // list button
        {

            button12.Show();

            panel1.Hide();
            panel2.Hide();



        }// list button

        public void invent()
        {
            using (SqlConnection cn = new SqlConnection(css.conn))
            {


                try
                {

                    cn.Open();
                    string st = "select order_transaction_id,o.order_id ,discount_id,staff_id,customer_id,ot.status,payment_method , transaction_date ,p.product_nmae,p.product_id ,quantity ,price , refil_price ,size from products as p, order_transaction as ot inner join orders AS o on o.order_id = ot.order_id";

                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = table;



                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }



        }

        New_Order nor = new New_Order();
        private void button7_Click(object sender, EventArgs e) // add orders
        {

            panel2.Show();

            selection s = new selection();
            s.FormBorderStyle = FormBorderStyle.None;
            s.TopLevel = false;
            s.Dock = DockStyle.Fill;

            s.AutoScroll = true;
            panel2.Controls.Add(s);

            s.Show();

            /*
             * panel1.Show();


                nor.Show();
                nor.FormBorderStyle = FormBorderStyle.None;
                nor.TopLevel = false;
                nor.Dock = DockStyle.Fill;

                nor.AutoScroll = true; 
                panel1.Controls.Add(nor);

                nor.Show();
                p.Hide();

             */


        } // add orders


        payment p = new payment();
        private void button6_Click(object sender, EventArgs e)// sell button
        {



            panel2.Hide();
            panel1.Hide();



            /*
             * p.Show();
               p.FormBorderStyle = FormBorderStyle.None;
               p.TopLevel = false;
               p.Dock = DockStyle.Fill;

               p.AutoScroll = true;
               panel1.Controls.Add(p);
           */
            p.Show();
            nor.Hide();

        }// sell button


        private void button2minmize_Click(object sender, EventArgs e) // see more button
        {
            button4inventory.Show();
            button3customers.Show();
            button2salesinfo.Show();
            button1orders.Show();
            button1.Show();


            button2.Hide();

            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8logout.Hide();

            p.Hide();
            nor.Hide();

        }// see more button

        private void button1_Click(object sender, EventArgs e)  // minimize button
        {
            button4inventory.Hide();
            button3customers.Hide();
            button2salesinfo.Hide();
            button1orders.Hide();
            button1.Hide();


            button2.Show();

            button5.Show();
            button6.Show();
            button7.Show();
            button8logout.Show();

        } //minimimze button


        customer2 c2 = new customer2();

        private void button3customers_Click(object sender, EventArgs e) // customer button
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
            s2.Hide();




        }// customer button

        inventory2 i2 = new inventory2();
        private void button4inventory_Click(object sender, EventArgs e) // inventory button
        {

            panel1.Show();



            i2.Show();
            i2.FormBorderStyle = FormBorderStyle.None;
            i2.TopLevel = false;
            i2.Dock = DockStyle.Fill;

            i2.AutoScroll = true;
            panel1.Controls.Add(i2);

            i2.Show();

            c2.Hide();
            o2.Hide();
            s2.Hide();



        }// inventory button

        order_2 o2 = new order_2();
        private void button1orders_Click(object sender, EventArgs e) // order button 
        {
            panel1.Show();

            o2.Show();
            o2.FormBorderStyle = FormBorderStyle.None;
            o2.TopLevel = false;
            o2.Dock = DockStyle.Fill;

            o2.AutoScroll = true;
            panel1.Controls.Add(o2);

            o2.Show();

            c2.Hide();
            i2.Hide();
            s2.Hide();


        } // order button 
        sales2 s2 = new sales2();
        private void button2salesinfo_Click(object sender, EventArgs e) // sales button
        {

            panel1.Show();

            s2.Show();
            s2.FormBorderStyle = FormBorderStyle.None;
            s2.TopLevel = false;
            s2.Dock = DockStyle.Fill;

            s2.AutoScroll = true;
            panel1.Controls.Add(s2);

            s2.Show();

            c2.Hide();
            i2.Hide();
            o2.Hide();



        } // sales button

        private void button8logout_Click(object sender, EventArgs e) // log out button
        {
            Form1 f2 = new Form1();
            f2.Show();



            c2.Hide();
            i2.Hide();
            o2.Hide();
            s2.Hide();

            button4inventory.Hide();
            button3customers.Hide();
            button2salesinfo.Hide();
            button1orders.Hide();
            button1.Hide();

            this.Hide();
            this.Close();

        }// log out button


    }
}
