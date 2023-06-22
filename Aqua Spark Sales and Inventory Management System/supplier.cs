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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }
        connection_class cn = new connection_class();
        private void button1_Click(object sender, EventArgs e)
        {



            try
            {

               

                using (SqlConnection cnn = new SqlConnection(cn.conn))
                {
                    cnn.Open();
                      string quer = " INSERT INTO staffs (first_name ,last_name,email,contact_number ) VALUES (@first_name ,@last_name,@email,@contact_number)";
                   

                  //  string quer1 = " INSERT INTO staffs (first_name ,last_name,email,contact_number ) VALUES ('" + textBoxfname + "' ,'" + textBoxlname + "','" + textBoxcontactno + "','" + textBoxemail + "')";
                  //  SqlCommand cmm = new SqlCommand(quer1, cnn);
                      SqlCommand command = new SqlCommand(quer, cnn);

                    command.Parameters.AddWithValue("@first_name",textBoxfname.Text);
                     command.Parameters.AddWithValue("@last_name",textBoxlname.Text);
                     command.Parameters.AddWithValue("@email",textBoxemail.Text);
                     command.Parameters.AddWithValue("@contact_number",textBoxcontactno.Text);
                   
                     command.ExecuteNonQuery();

                    cnn.Close();


                }

              


            }
            catch
            {
                MessageBox.Show("Error ");
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


    }
}
