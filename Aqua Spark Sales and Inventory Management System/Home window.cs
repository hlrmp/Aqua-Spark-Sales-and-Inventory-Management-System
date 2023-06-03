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
    public partial class Home_window : Form
    {
        public Home_window()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) // list button
        {
            listBox1.Show();

        }// list button

        private void button7_Click(object sender, EventArgs e) // add orders
        {
            New_Order nor = new New_Order();
            nor.Show();

            listBox1.Hide();

        } // add orders
    }
}
