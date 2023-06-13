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
    public partial class Sales_window : Form
    {
        public Sales_window()
        {
            InitializeComponent();
        }
        connection_class noc = new connection_class();

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

        public void saleswindow()
        {
            using (SqlConnection cn = new SqlConnection(noc.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT i.inventory_id, p.product_id ,s.supplier_id, i.quantity ,i.date_added FROM inventory AS s,products AS p INNER JOIN inventory AS i on i.product_id = p.product_id;\r\n";
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


            private void button4_Click(object sender, EventArgs e) // total sales
            {
                saleswindow();

            }//otal sales
    }
}