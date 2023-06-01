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

        private void button5_Click(object sender, EventArgs e) // list button
        {
            listBox1.Show();
            buttonpay.Hide();
            buttoncncel.Hide();
            checkedListBox1.Hide();
        }// list button

        private void button6_Click(object sender, EventArgs e) // sell button
        {
            checkedListBox1.Show();
            buttonpay.Show();
            buttoncncel.Show();
            listBox1.Hide();
        }// sell button

        private void button7_Click(object sender, EventArgs e) // add order
        {
            New_Order no = new New_Order();
            no.Show();

            checkedListBox1.Hide();
            buttonpay.Hide();
            buttoncncel.Hide();
            listBox1.Hide();

        }// add order
    }
}
