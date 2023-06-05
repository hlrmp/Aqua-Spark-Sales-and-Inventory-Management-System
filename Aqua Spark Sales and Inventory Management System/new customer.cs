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
    public partial class new_customer : Form
    {
        public new_customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // cancel button
        {
            textBoxfname.Clear();
            textBoxlname.Clear();
            textBoxaddress.Clear();
            textBoxcontactno.Clear();
            textBoxemail.Clear();

            this.Hide();

        }// cancel button

        private void button3_Click(object sender, EventArgs e) // clear buton 
        {
            textBoxfname.Clear();
            textBoxlname.Clear();
            textBoxaddress.Clear();
            textBoxcontactno.Clear();
            textBoxemail.Clear();

        } // clear button
    }
}
