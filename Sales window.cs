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
    public partial class Sales_window : Form
    {
        public Sales_window()
        {
            InitializeComponent();
        }

        private void Sales_window_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_window mwd = new main_window();
            mwd.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)  // from order
        {
            
        }// from order

    }
}
