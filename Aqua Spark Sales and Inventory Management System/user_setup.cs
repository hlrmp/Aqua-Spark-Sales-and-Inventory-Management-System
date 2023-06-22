using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class user_setup : Form
    {
        public user_setup()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)     // password show
        {
            if (checkBox1.Checked == true)
            {
                textBox2_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2_password.UseSystemPasswordChar = true;
            }
        }    // password show

        private void button3_Click(object sender, EventArgs e) // clear button
        {
            textBox1_username.Clear();
            textBox2_password.Clear();

        }// clear button
    }
}
