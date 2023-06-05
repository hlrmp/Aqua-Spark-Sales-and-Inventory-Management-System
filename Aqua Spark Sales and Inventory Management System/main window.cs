using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)  // inventory window
        {
            Inventory_Wiindow iw = new Inventory_Wiindow();
            iw.Show();
            this.Hide();


        }  // inventory window


        private void button2_Click(object sender, EventArgs e) // sales window
        {
            Sales_window sw = new Sales_window();
            sw.Show();
            this.Hide();

        } // sales window


        private void button8_Click(object sender, EventArgs e)  // log out window
        {
            /*  log_in_window lg = new log_in_window();
              lg.Show(); */
            if (button8logout != null)
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();



                MessageBox.Show(" are yu sure o log out ? ", "log out", MessageBoxButtons.YesNo);

                button4inventory.Hide();
                button3customers.Hide();
                button2salesinfo.Hide();
                button1orders.Hide();
                button12.Hide();
                listBox1.Hide();
                no.Hide();
                py.Hide();


            }
        } // log out window

        private void button1_Click(object sender, EventArgs e)  // orders window
        {
            Orders_Window ow = new Orders_Window();
            ow.Show();
            this.Hide();

        }  // orders window


        private void button3_Click(object sender, EventArgs e) // customers windows 
        {
            Customers_Window cw = new Customers_Window();
            cw.Show();
            this.Hide();

        } // customers windows 

        private void button5_Click(object sender, EventArgs e) // list button
        {
            listBox1.Show();
            button12.Show();
            buttonpay.Hide();
            buttoncncel.Hide();

        }// list button

        payment py = new payment();
        private void button6_Click(object sender, EventArgs e) // sell button
        {


            py.Show();
            no.Hide();

            button12.Hide();
            listBox1.Hide();
        }// sell button

        New_Order no = new New_Order();
        private void button7_Click(object sender, EventArgs e) // add order
        {

            no.Show();
            py.Hide();

            button12.Hide();
            buttonpay.Hide();
            buttoncncel.Hide();
            listBox1.Hide();

        }// add order

        private void button12_Click(object sender, EventArgs e) // x button list box
        {
            listBox1.Hide();
            button12.Hide();
            buttonpay.Hide();
            buttoncncel.Hide();

        }// x button list box



        private void button2minmize_Click(object sender, EventArgs e) // minimize button
        {
            button4inventory.Hide();
            button3customers.Hide();
            button2salesinfo.Hide();
            button1orders.Hide();
            button2minmize.Hide();
            pictureBox1.Hide();

            button1.Show();

            button5.Show();
            button6.Show();
            button7.Show();
            button8logout.Show();

        } //minimimze button

        private void button1_Click_1(object sender, EventArgs e) // see more button
        {
            button4inventory.Show();
            button3customers.Show();
            button2salesinfo.Show();
            button1orders.Show();
            button2minmize.Show();
            pictureBox1.Show();


            button1.Hide();

            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8logout.Hide();
        }// see more button
    }
}
