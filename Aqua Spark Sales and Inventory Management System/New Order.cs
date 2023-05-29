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
    public partial class New_Order : Form
    {
        public New_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // cancel button
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
          
            this.Close();
        }// cancel button
    }
}
