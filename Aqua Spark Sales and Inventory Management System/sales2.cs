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
    public partial class sales2 : Form
    {
        public sales2()
        {
            InitializeComponent();
        }
        connection_class cnn = new connection_class();
        private void button1_Click(object sender, EventArgs e) // home button
        {
            Home_window hm4 = new Home_window();
            hm4.Show();
            this.Hide();

        }// home button

        private void button4_Click(object sender, EventArgs e)  // TOTAL SALES BUTTON
        {
            see();

        }// TOTAL SALES BUTTON



        public void see()
        {
            using (SqlConnection cn = new SqlConnection(cnn.conn))
            {


                try
                {

                    cn.Open();
                    string st = "select * from order_transaction;";
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_sales.DataSource = table;


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

    }
}
