using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
            sign();
        }



        private void buttoncncel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // see employee
        {


        } // see employee

        private void button4inventory_Click(object sender, EventArgs e) // add employee
        {
            textBoxpassword.Show();
            textBoxusername.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            comboBox1.Show();
            buttona.Show();
            buttonb.Show();
            buttonc.Show();

        }// add employee
        connection_class cs = new connection_class();

        private void sign()
        {
            SqlConnection cn = new SqlConnection(cs.conn);  
            
            // Create a new data adapter based on the specified query.
            SqlDataAdapter adapt = new SqlDataAdapter();

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder();

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand();
    

            string st = ("SELECT * FROM staffs");
           
            command = new SqlCommand(st, cn);

            dataGridView1.Columns.Add("stid", "staff_id");
            dataGridView1.Columns.Add("stfn", " firstname");
            dataGridView1.Columns.Add("stln", " lastname");
            dataGridView1.Columns.Add("ste", " email");
            dataGridView1.Columns.Add("stcn", " contact number");
            dataGridView1.Rows.Add(st);
          //  dataGridView1.DataSource = ("SELECT * FROM staffs");
        }

        private void button1_Click(object sender, EventArgs e) // home button
        {
            main_window m2 = new main_window();
            m2.Show();
            this.Hide();

        }// home button
    }
}
