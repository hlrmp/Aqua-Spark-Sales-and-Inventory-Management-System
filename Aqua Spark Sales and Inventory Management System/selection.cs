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
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }
        order3 o3 = new order3();
        private void buttonOLD_Click(object sender, EventArgs e)
        {

            o3.Show();

            no.Hide();

        }



        New_Order no = new New_Order();
        private void buttonNEW_Click_1(object sender, EventArgs e)
        {

            no.Show();

            o3.Hide();

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Hide();


        }
    }
}
