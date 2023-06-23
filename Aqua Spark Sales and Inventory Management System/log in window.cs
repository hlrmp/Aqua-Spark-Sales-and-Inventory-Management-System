using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.Identity.Client;
using System.Drawing.Design;
using System.Text.RegularExpressions;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class log_in_window : Form
    {
        public log_in_window()
        {
            InitializeComponent();
        }


        user_class uc = new user_class();  // user class instance
        connection_class cnc = new connection_class();  // database connection instance
                                                        //          string cn =                                      // SqlConnection connection = new SqlConnection();


        private void button1_Click(object sender, EventArgs e)   // log in button
        {
            login();
           

        }  // log in button 




        private void button2_Click(object sender, EventArgs e) // back button
        {
            if (button2 != null)
            {
                this.Hide();


            }
            else
            {

            }
        } // back button




        private void checkBox1_CheckedChanged(object sender, EventArgs e)     // password show
        {
            if (checkBox1.Checked == true)
            {
                textBox2_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2_password.UseSystemPasswordChar = true;
            }
        }    // password show

        private void button3_Click(object sender, EventArgs e) // clear button
        {
            textBox1_username.Clear();
            textBox2_password.Clear();

        }// clear button




        string un;
        string pass;
        public void login()
        {
            using (SqlConnection connection = new SqlConnection(cnc.conn))
            {
                //try
                //{
                    if (!string.IsNullOrEmpty(textBox1_username.Text) && !string.IsNullOrEmpty(textBox2_password.Text))
                    {
                        un = textBox1_username.Text;
                        pass = textBox2_password.Text;
                        // Open the connection
                        connection.Open();


                        string quer = " SELECT user_name , password, user_type FROM users WHERE user_name = '" + un + "'  AND password =  '" + pass + "' ";
                        //     string quer = "  SELECT user_name ,password , user_type FROM users WHERE user_name = 'a'  AND password =  'b' " ;

                        SqlCommand command;
                        command = new SqlCommand(quer, connection);
                        SqlDataReader reader = command.ExecuteReader();






                        if (reader.Read())
                        {
                            MessageBox.Show(" log in succesfully ");

                             lgs();

                            if (reader[2].Equals("manager"))

                            {

                                main_window mw = new main_window();
                                mw.Show();
                                this.Hide();

                            }
                            else if (reader[2].Equals("cashier"))
                            {


                                Home_window hm = new Home_window();
                                hm.Show();
                                this.Hide();

                            }


                        }
                        else
                        {
                            MessageBox.Show(" user name or password incorect");
                        }
                    }

                    else
                    {
                        if (textBox1_username.Text == "")
                        {
                            MessageBox.Show(" Enter your user name ");
                        }
                        else if (textBox2_password.Text == "")
                        {
                            MessageBox.Show(" Enter your password ");
                        }

                    connection.Close();
                }
              /*  }
                catch (Exception)
                {
                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK);
                }
                finally     // to close the connection
                {
                    connection.Close();
                } // to close the connection

                */
            }// using connection
        }

        public void lgs()
        {

            //try
            //{



                using (SqlConnection cnn = new SqlConnection(cnc.conn))
                {
                    cnn.Open();



                    string quer = " SELECT user_name , password, user_type FROM users WHERE user_name = '" + un + "'  AND password =  '" + pass + "' ";
 

                    SqlCommand command;
                    command = new SqlCommand(quer, cnn);
                    SqlDataReader reader = command.ExecuteReader();

                     reader.Read();

                     


                    string da = DateTime.Now.ToString("M/d/yyyy");
                    string inn = ("INSERT INTO activity_logs(user_id,activity_description ,activity_date)values('" + reader[0] + "','login','"+ da +"' ");
                    SqlCommand command1 = new SqlCommand(inn, cnn);
                      
                    command1.ExecuteNonQuery();

                    cnn.Close();




                }



            //}
            //catch
            //{
            //    MessageBox.Show("Error something went wrong ");
            //}
        }
    }
}

