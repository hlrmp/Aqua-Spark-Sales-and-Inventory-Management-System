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
    public partial class order_2 : Form
    {
        public order_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // home button 
        {
            Home_window hm3 = new Home_window();
            hm3.Show();
            this.Hide();

        } // home button 
    }
}
