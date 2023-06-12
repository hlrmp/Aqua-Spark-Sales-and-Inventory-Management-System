using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.SqlClient;


namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class Orders_Window : Form
    {
        public Orders_Window()
        {
            InitializeComponent();
            seeorders();
        }
        connection_class cn = new connection_class();


        public void seeorders()
        {
            SqlConnection sqlconn = new SqlConnection(cn.conn);
            sqlconn.Open();
            //  string str = "select * from order_tansactions";
            string sj = "select CONCAT(c.first_name, c.last_name)AS 'full name' ,p.product_id,order_id ,product_name,quantity\r\nfrom customer AS c,products AS p INNER JOIN orders AS o on p.product_id = o.product_id";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlconn);
            DataTable table = new DataTable();

            data.Fill(table);

            //   dataGridView_order.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_order.DataSource = table;


            sqlconn.Close();

        }
        private void button1_Click(object sender, EventArgs e) // HOME WINDOWS
        {
            main_window mw1 = new main_window();
            mw1.Show();
            this.Hide();

        } // HOME WINDOWS

        private void button2_Click(object sender, EventArgs e) // add order button 
        {
            New_Order nw = new New_Order();
            nw.Show();

        }// add order button 

        private void pictureBox1_Click(object sender, EventArgs e) // seaarch 
        {

        }// seaarch 

        private void button3_Click(object sender, EventArgs e) // edit button
        {

        }//edit button
    }
}
