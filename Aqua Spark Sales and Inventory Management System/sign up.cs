using System;
using System.Collections;
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
            type();

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



                    cn.Open();
                    string st = "select user_id , s.staff_id , s.first_name ,s.last_name ,s.email , s.contact_number, user_type from users as u right join staffs as s ON u.staff_id = s.staff_id\r\n";
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.DataSource = table;

                    cn.Close();

                } // to close the connection


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

            conect.Open();
            string list = "SELECT activity_id ,a.user_id,user_name ,user_type ,activity_description , activity_date FROM users AS u  INNER JOIN activity_logs AS a on u.user_id = a.user_id ";
            SqlDataAdapter data = new SqlDataAdapter(list, conect);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;



            conect.Close();

        }
        public void staff()
        {
            SqlConnection conect = new SqlConnection(cs.conn);

            conect.Open();
            string list = "select * from staffs ";
            SqlDataAdapter data = new SqlDataAdapter(list, conect);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;



            conect.Close();

        }

        public void users()
        {
            SqlConnection conect = new SqlConnection(cs.conn);

            conect.Open();
            string list = "select * from users ";
            SqlDataAdapter data = new SqlDataAdapter(list, conect);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;



            conect.Close();

        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "users")
            {
                users();
                dataGridView1.Refresh();

            }
            else if (comboBox2.Text == "staffs")
            {
                staff();
                dataGridView1.Refresh();
            }
        }

        public void type()
        {
            ArrayList clist = new ArrayList();

            clist.Add("users");
            clist.Add("staffs");

            foreach (string pos in clist)
            {
                comboBox2.Items.Add(pos);
            }

        }
    }
}
