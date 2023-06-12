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
            
        }



        private void buttoncncel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // see employee
        {
            sign();

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

        public void sign()
        {
            using (SqlConnection cn = new SqlConnection(cs.conn))
            {


                try
                {

                    cn.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand();
                    string st = "SELECT * FROM staffs";
                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);
                  
                   //   command = new SqlCommand(st, cn);
                  //   SqlDataReader reader = command.ExecuteReader();
                   // dataGridView1.DataSource = reader.Read();

                    // dataGridView1.Columns.Add("stid", "staff_id");
                    //dataGridView1.Columns.Add("stfn", " firstname");
                    // dataGridView1.Columns.Add("stln", " lastname");
                    // dataGridView1.Columns.Add("ste", " email");
                    // dataGridView1.Columns.Add("stcn", " contact number");
                    // dataGridView1.Rows.Add(st);
                    //   dataGridView1.DataSource = ("SELECT * FROM staffs");

                    //    SqlCommand command = new SqlCommand();
                    //   command = new SqlCommand(quer, connection);
                    // SqlDataReader reader = command.ExecuteReader();



                    /*
                     *  cn.Open();
                    // Create a new data adapter based on the specified query.
                    SqlDataAdapter adapt;

                    // Create a command builder to generate SQL update, insert, and
                    // delete commands based on selectCommand.
                    SqlCommandBuilder commandBuilder;
                    // Populate a new data table and bind it to the BindingSource.


                    SqlCommand command = new SqlCommand();
                    command = cn.CreateCommand();
                    command.CommandType = new CommandType();
                    
                    string st = "SELECT * FROM staffs;";
                    DataTable table = new DataTable();

                    adapt = new SqlDataAdapter(st, cn);
                    adapt.Fill(table);

                    //  command = new SqlCommand(st, cn);

                    dataGridView1.DataSource = table;

                     */

                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("error", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }



        }

        private void button1_Click(object sender, EventArgs e) // home button
        {
           // main_window m2 = new main_window();
          //  m2.Show();
            this.Hide();

        }// home button
    }
}
