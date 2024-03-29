﻿using System;
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
            button1.Show();
            pictureBox1.Show();


            button2.Hide();

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
            button1.Hide();
            pictureBox1.Hide();

            button2.Show();

            button5.Show();
            button6.Show();
            button7.Show();
            button8logout.Show();

        } //minimimze button

        private void button3customers_Click(object sender, EventArgs e) // customer button
        {
            customer2 c2 = new customer2();
            c2.Show();
            this.Hide();

        }// customer button

        private void button4inventory_Click(object sender, EventArgs e) // inventory button
        {
            inventory2 i2 = new inventory2();
            i2.Show();
            this.Hide();

        }// inventory button

        private void button1orders_Click(object sender, EventArgs e) // order button 
        {
            order_2 o2 = new order_2();
            o2.Show();
            this.Hide();

        } // order button 

        private void button2salesinfo_Click(object sender, EventArgs e) // sales button
        {
            sales2 s2 = new sales2();
            s2.Show();
            this.Hide();

        } // sales button

        private void button8logout_Click(object sender, EventArgs e) // log out button
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Close();

        }// log out button
    }
}
