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
    public partial class Inventory_Wiindow : Form
    {
        public Inventory_Wiindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // HOME
        {
            main_window mw = new main_window();
            mw.Show();
            this.Hide();
        } // HOME


    }
}
