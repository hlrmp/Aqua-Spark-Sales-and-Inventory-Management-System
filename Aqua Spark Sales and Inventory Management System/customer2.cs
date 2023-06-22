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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class customer2 : Form
    {
        public customer2()
        {
            InitializeComponent();
            seecustomers();
        }
        // 1 encapsulation customer info
        connection_class cc = new connection_class();

        private void button1_Click(object sender, EventArgs e) // home button 
        {
            Home_window hm1 = new Home_window();
            hm1.Show();
            this.Hide();

        }// home button 

        public void seecustomers()
        {
            SqlConnection sqlcc = new SqlConnection(cc.conn);
            try
            {
                /*
                string str = "select product_name from products";
                SqlCommand cmd = new SqlCommand(str, sqlcc);

                */
                string sj = "select * from customer";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                //   dataGridView_order.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView_sales.DataSource = table;


            }
            catch
            {
                MessageBox.Show(" something went wrong ");
            }

            finally
            {
                sqlcc.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seecustomers();
        }

       
    
    new_customer nw = new new_customer();
    private void button2_Click(object sender, EventArgs e)
        {
        nw.Show();
        }

      
        
    }
}
