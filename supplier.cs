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

                //  cs.lname = txtlname;
                //  cs.ftname = txtlname;
                //   cs.addr = txtadd;
                //   cs.contacnum = txtcon;
                //   cs.e = txte;


                using (SqlConnection cnn = new SqlConnection(cn.conn))
                {
                    cnn.Open();
                    //    string quer = " INSERT INTO customer (first_name ,last_name,address,contact_number,email ) VALUES (@first_name ,@last_name,@address,@contact_number,@email)";
                    //   SqlCommand command = new SqlCommand(quer, cnn);

                    string quer1 = " INSERT INTO customer (first_name ,last_name,address,contact_number,email ) VALUES ('" + textBoxfname + "' ,'" + textBoxlname + "','" + textBoxaddress + "','" + textBoxcontactno + "','" + textBoxemail + "')";
                    SqlCommand cmm = new SqlCommand(quer1, cnn);

                    //  command.Parameters.AddWithValue("@first_name",textBoxfname.Text);
                    //   command.Parameters.AddWithValue("@last_name",textBoxlname.Text);
                    //  command.Parameters.AddWithValue("@address",textBoxaddress.Text);
                    //  command.Parameters.AddWithValue("@contact_number",Convert.ToInt32( textBoxcontactno.Text));
                    //  command.Parameters.AddWithValue("@email",textBoxemail.Text);
                    // command.ExecuteNonQuery();

                    cnn.Close();


                }

              //  textBoxlname.Clear();
              //  textBoxfname.Clear();
              //  textBoxaddress.Clear();
              //  textBoxcontactno.Clear();
              //  textBoxemail.Clear();

                //   sign_up Up = new sign_up();
                //  Up.Refresh();
                //  this.Refresh();
                // this.Hide();



            }
            catch
            {
                MessageBox.Show("Error ");
            }








            /* using (SqlConnection connect = new SqlConnection(cn.conn))
             {
                 connect.Open();

                 string sql = "INSERT INTO supplier (first_name, last_name, Address, Contact_Number, Email) VALUES (@last_name, @first_name ,@Address, @Contact_Number, @Email,)";
                 SqlCommand command = new SqlCommand(sql, connect);
                 command.Parameters.AddWithValue("@last_name", textBoxlname.Text);
                 command.Parameters.AddWithValue("@first_name", textBoxfname.Text);
                 command.Parameters.AddWithValue("@Address", textBoxaddress.Text);
                 command.Parameters.AddWithValue("@Contact_Number", textBoxcontactno.Text);
                 command.Parameters.AddWithValue("@Email", textBoxemail.Text);

                 command.ExecuteNonQuery();

                 connect.Close();


                 MessageBox.Show(" succesfully added !! ", " new customer ", MessageBoxButtons.OK);

            }
         */
        }

        private void button2_Click(object sender, EventArgs e) // cancell button
        {
            textBoxlname.Clear();
            textBoxfname.Clear();
            textBoxaddress.Clear();
            textBoxcontactno.Clear();
            textBoxemail.Clear();

            this.Hide();

        }// cancell button
    }
}
