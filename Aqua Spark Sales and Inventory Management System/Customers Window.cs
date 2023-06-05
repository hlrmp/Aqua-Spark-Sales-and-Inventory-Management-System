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
    public partial class Customers_Window : Form
    {
        public Customers_Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // HOME WINDOWS
        {
            main_window mw1 = new main_window();
            mw1.Show();
            this.Hide();

        }  // HOME WINDOWS

        private void button2_Click(object sender, EventArgs e) // add customer
        {
            new_customer nc = new new_customer();
            nc.Show();

        }// add customer
    }
}
