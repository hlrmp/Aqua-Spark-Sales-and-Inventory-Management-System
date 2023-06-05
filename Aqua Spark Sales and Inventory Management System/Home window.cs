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
            button12.Show();


        }// list button

        private void button7_Click(object sender, EventArgs e) // add orders
        {
            New_Order nor = new New_Order();
            nor.Show();

            listBox1.Hide();

        } // add orders

        private void button2minmize_Click(object sender, EventArgs e) // see more button
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

        private void button1_Click(object sender, EventArgs e)  // minimize button
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
    }
}
