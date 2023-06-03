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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e) // edit button
        {
            // dataGridView1
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

        }// edit button

        private void button1_Click(object sender, EventArgs e) // cancel button
        {
            this.Hide();

        }// cancel button
    }
}
