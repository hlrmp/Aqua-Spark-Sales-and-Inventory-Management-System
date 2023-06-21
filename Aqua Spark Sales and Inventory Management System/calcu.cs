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
    public partial class calcu : Form
    {
        public calcu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1 != null)
            {
                one = int.Parse(textBox1.Text);

            }
        }
        public int one = 1;


        public int numone()
        {
            return one;



        }
    }
}
