using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }

        public string fn;
        public string ln;

        connection_class cn = new connection_class();
        user_setup us = new user_setup();
        private void button1_Click(object sender, EventArgs e)
        {
            fn = textBoxfname.Text;
            ln = textBoxlname.Text;

            try
            {
                if (button1 != null)
                {
                    us.Show();

                    using (SqlConnection cnn = new SqlConnection(cn.conn))
                    {
                        cnn.Open();
                        string quer = " INSERT INTO staffs (first_name ,last_name,email,contact_number ) VALUES (@first_name ,@last_name,@email,@contact_number)";

                        SqlCommand command = new SqlCommand(quer, cnn);

                        command.Parameters.AddWithValue("@first_name", fn);
                        command.Parameters.AddWithValue("@last_name", ln);
                        command.Parameters.AddWithValue("@email", textBoxemail.Text);
                        command.Parameters.AddWithValue("@contact_number", textBoxcontactno.Text);

                        command.ExecuteNonQuery();

                        cnn.Close();
                    }


                }
                else
                {

                }




            }
            catch
            {
                MessageBox.Show("error something might wrong ");
            }


        }

        private void button2_Click(object sender, EventArgs e) // cancell button
        {
            textBoxlname.Clear();
            textBoxfname.Clear();

            textBoxcontactno.Clear();
            textBoxemail.Clear();

            this.Hide();

        }// cancell button

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxlname.Clear();
            textBoxfname.Clear();

            textBoxcontactno.Clear();
            textBoxemail.Clear();

        }
    }
}
