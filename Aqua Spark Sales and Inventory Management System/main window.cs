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



    }
}
