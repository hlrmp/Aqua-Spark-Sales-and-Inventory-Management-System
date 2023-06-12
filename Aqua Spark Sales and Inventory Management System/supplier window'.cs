using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class supplier_window_ : Form
    {
        public supplier_window_()
        {
            InitializeComponent();
        }
        connection_class cc = new connection_class();
        private void button1_Click(object sender, EventArgs e) // home button
        {
            main_window mw = new main_window();
            mw.Show();
            this.Hide();

        } // home button

        private void button4_Click(object sender, EventArgs e)// supplier list
        {
            supply();

        }//supplier list\


        public void supply()
        {
            using (SqlConnection cn = new SqlConnection(cc.conn))
            {


                try
                {

                    cn.Open();
                    string st = "select *  from  supplier;";
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = table;



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

            private void button2_Click(object sender, EventArgs e) // add supplier button
            {
            supplier su = new supplier();
            su.Show();
            
            } // add supplier button
        }
    }