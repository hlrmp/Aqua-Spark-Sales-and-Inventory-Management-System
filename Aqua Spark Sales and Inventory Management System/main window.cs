using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            log_in_window lg = new log_in_window();
            lg.Show();
            this.Close();

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
    }
}
