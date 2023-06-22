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
            dataGridView1.Show();
            sign();

        } // see employee


        supplier s = new supplier();
        private void button4inventory_Click(object sender, EventArgs e) // add employee
        {
            s.Show();
        }// add employee
        connection_class cs = new connection_class();

        public void sign()
        {
            using (SqlConnection cn = new SqlConnection(cs.conn))
            {


                try
                {

                    cn.Open();
                    string st = "SELECT s.staff_id , first_name , last_name , email , contact_number ,user_type FROM users AS u INNER JOIN staffs AS s ON s.staff_id = u.staff_id";
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

        private void button1_Click(object sender, EventArgs e) // home button
        {
            // main_window m2 = new main_window();
            //  m2.Show();
            this.Hide();

        }// home button

        private void button2_Click(object sender, EventArgs e)
        {
            supplier supp = new supplier();
            supp.Show();

        }

        private void button4_Click(object sender, EventArgs e) // employee button
        {
            actlogs();

        }// employee button


        public void actlogs()
        {
            SqlConnection conect = new SqlConnection(cs.conn);
            try
            {
                conect.Open();
                string list = "SELECT activity_id ,a.user_id,user_name ,user_type ,activity_description , activity_date FROM users AS u \r\n  INNER JOIN activity_logs AS a on u.user_id = a.user_id ;";
                SqlDataAdapter data = new SqlDataAdapter(list, conect);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


            }
            catch
            {
                MessageBox.Show("Error ", "something went wrong", MessageBoxButtons.OK);
            }

            finally
            {
                conect.Close();
            }
        }
    }
}
