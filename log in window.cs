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
//using Aqua_Spark;
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

        //  SqlConnection connection = new SqlConnection();
        //  SqlCommand command;
        //   SqlDataReader rd;

        private void button1_Click(object sender, EventArgs e)   // log in button
        {
            using (SqlConnection connection = new SqlConnection(cnc.conn))
            {


                try
                {
                    string txtuser = textBox1_username.Text;
                    string txtpass = textBox2_password.Text;

                    if (string.IsNullOrEmpty(textBox1_username.Text) ||
                                string.IsNullOrEmpty(textBox2_password.Text))
                    {
                        if (textBox1_username.Text == "")
                        {
                            MessageBox.Show(" Enter your user name ");

                        }
                        else if (textBox2_password.Text == "")
                        {
                            MessageBox.Show(" Enter your password ");
                        }
                    }
                    else ///if (!string.IsNullOrEmpty(textBox1_username.Text) ||
                        // !string.IsNullOrEmpty(textBox2_password.Text))
                    {

                        // Open the connection


                        uc.username = txtuser;
                        uc.userpas = txtpass;

                        //   uc.uid = "SELECT * FROM users WHERE user_id = '1'";
                        //     MessageBox.Show(uc.uid);
                        connection.Open();

                        // string quer = "SELECT * FROM users WHERE user_name = '" + txtuser + "' AND password = ' " + txtpass + "'";

                        string quer = "  SELECT user_name ,password , user_type FROM users WHERE user_name = '" + uc.username + "'  AND password =  '" + uc.userpas + "' ";
                        
                        SqlCommand command = new SqlCommand();
                        command = new SqlCommand(quer, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        //  string quer1 = "  SELECT user_type FROM users WHERE user_name = '" + uc.username + "'  AND password =  '" + uc.userpas + "' ";
                        //  SqlCommand command1 = new SqlCommand();
                         // command1 = new SqlCommand(quer1, connection);
                         // SqlDataReader reader1 = command1.ExecuteReader();


                   
                        if (reader.Read())
                        {
                            // if ( )
                            //{
                           // uc.utype = " " + reader;
                            main_window fmain = new main_window();    // main window instance
                            fmain.Show();   // show main form 
                            this.Hide();
                             //quer1.ToString();
                            if (uc.utype.Equals("manager"))
                            {
                                MessageBox.Show("MANAGER");
                            }
                            else if (uc.utype.Equals("cashier"))
                            {
                                MessageBox.Show("CASHIER");
                                Home_window hm1 = new Home_window();
                                //     hm1.Show();
                                //     this.Hide();
                            }

                            //   }
                            //    else
                            //     {
                            //        MessageBox.Show(" user name or password incorect");
                            //     }

                        }
                        else
                        {
                            MessageBox.Show(" user name or password incorect");
                        }



                        /*
                                              string staff = ("SELECT user_type  FROM user where user_type = admin");
                                               SqlCommand command1 = new SqlCommand();
                                               command1 = new SqlCommand(staff);
                                               SqlDataReader reader1 = command1.ExecuteReader();



                                               string staffs = ("SELECT user_type  FROM user where user_type = cashier");
                                               SqlCommand command2 = new SqlCommand();
                                               command1 = new SqlCommand(staffs);
                                               SqlDataReader reader2 = command1.ExecuteReader();

                                           */


                        // else if (reader.Read() && reader2.Read())
                        //  {
                        //       Home_window hm1 = new Home_window();
                        //       this.Hide();
                        //}
                        //   } // using connection
                    }


                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("error", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    connection.Close();

                } // to close the connection


            }// using connection
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


        public void position()
        {
            SqlConnection sqlc = new SqlConnection(cnc.conn);
            try
            {
                
                string str = "  SELECT user_type FROM users WHERE user_name = '" + uc.username + "'  AND password =  '" + uc.userpas + "' ";

              //  string str = "select product_name from products";
                SqlCommand cmd = new SqlCommand(str, sqlc);
                cmd.CommandText = str;
                sqlc.Open();
                SqlDataReader drd = cmd.ExecuteReader();

               uc.utype = drd.ToString();
            }
            catch
            {
                MessageBox.Show("Error ");
            }

            finally
            {
                sqlc.Close();
            }
        }
    }
}


/*
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using Aqua_Spark;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class log_in_window : Form
    {
        public log_in_window()
        {
            InitializeComponent();

        }

        connection_class cnc = new connection_class();

        private void button1_Click(object sender, EventArgs e)   // log in button
        {

          try
          {

                if (string.IsNullOrEmpty(textBox1_username.Text) ||
                string.IsNullOrEmpty(textBox2_password.Text))
            {
                if (textBox1_username.Text == "")
                {
                    MessageBox.Show(" Enter your user name ");
                }
                else if (textBox2_password.Text == "")
                {
                    MessageBox.Show(" Enter your password ");
                }
            }
            else if (!string.IsNullOrEmpty(textBox1_username.Text) ||
                 !string.IsNullOrEmpty(textBox2_password.Text))
            {

                using (SqlConnection connection = new SqlConnection(cnc.data_connection())) // database connection access
               
                    connection.Open();  // Open the connection

                string username, password;

                username = textBox1_username.Text;
                password = textBox2_password.Text;

                string quer = "SELECT * FROM [users] WHERE user_name = '" + username +
                    "' AND Password = '" + password + "' " ;

                SqlCommand command = new SqlCommand();
                command = new SqlCommand(quer);
                SqlDataReader reader = command.ExecuteReader();

                string staff = ("SELECT [user_type]  FROM [log in] where user_type = admin");
                SqlCommand command1 = new SqlCommand();
                command1 = new SqlCommand(staff);
                SqlDataReader reader1 = command1.ExecuteReader();

                string staffs = ("SELECT [user_type]  FROM [log in] where user_type = cashier");
                SqlCommand command2 = new SqlCommand();
                command1 = new SqlCommand(staffs);
                SqlDataReader reader2 = command1.ExecuteReader();

                  if (reader.Read() && reader1.Read())
                  {
                   main_window fmain = new main_window();    // main window instance
                   fmain.Show();   // show main form 
                    this.Hide();
                  }

                  else if (reader.Read() && reader2.Read())
                  {
                    Home_window hm1 = new Home_window();
                    hm1.Show();
                    this.Hide();
                  }

            }
            else
            {
                    MessageBox.Show(" user name or password incorect"); 

             //   Home_window hm1 = new Home_window();
               // hm1.Show();
                //  this.Hide();

                // main_window fmain = new main_window();    // main window instance
                //  fmain.Show();   // show main form 
                //this.Hide();
            }
          }
            catch (Exception)
            {



                MessageBox.Show("error", "error", MessageBoxButtons.OK);


            }
            //     finally
            //    {
            //         conn.Close();
            //    }
        }
        //    main_window fmain = new main_window();    // main window instance
        //  fmain.Show();   // show main form 
        // this.Hide();   // hide this form 
        //    }


       try
              {

                  string username, password;

                  username = textBox1_username.Text;
                  password = textBox2_password.Text;


                  string querusername = ("SELECT [USER NAME]  FROM [log in] where lid = 1");
                  string querpass = "SELECT PASSWORD FROM [log in] where lid = 1 ";



                 string querusername2 = "SELECT USER NAME FROM log in WHERE lid = 2 ";
                 string querpass2 = "SELECT PASSWORD FROM log in WHERE lid = 2 ";



                 // SqlDataAdapter sd = new SqlDataAdapter(quer,conn);

                 //DataTable table = new DataTable(quer);
                 //sd.Fill(table);

                 //string querlognum = "SELECT * FROM log in WHERE lid IN('1')"; // user name and password 1 
                 //string querlognum2 = "SELECT * FROM log in WHERE lid IN('1')"; // user name and password 2
                 //   string queruser = " SELECT USER NAME FROM log in WHERE condition";

                 int c = 1;
                  int a = 1;


                  if (username == (querusername) && password == (querpass))   // admin acc
                  {
                   //   username = textBox1_username.Text;
                     // password = textBox2_password.Text;

                      textBox1_username.Clear();
                      textBox2_password.Clear();

                      MessageBox.Show("log in succesfully", "thank you", MessageBoxButtons.OK);

                      //  if (username == querlognum && password == querlognum)
                      // { // if user name & pass == to cashier


                      //string querlogcount = " INSERT INTO CASHIER ACC (LOG COUNT) VALUES(c);";
                      //    }

                      //  if (username == querlognum2 && password == querlognum2) // if user name & pass == to admin
                      //  {

                      //       string querlogcount2 = " INSERT INTO ADMIN ACC (LOG COUNT) VALUES(a);";
                      //  }

                      main_window fmain = new main_window();    // main window instance

                      fmain.Show();   // show main form 
                      this.Hide();   // hide this form 
                  } // admin acc

                  else if (username.Equals(querusername2) && password.Equals(querpass2))  // cashier acc
                 {
                     textBox1_username.Clear();
                     textBox2_password.Clear();

                     MessageBox.Show("log in succesfully", "thank you", MessageBoxButtons.OK);

                     Home_window hm = new Home_window();   // home window
                     hm.Show();     // show home form 
                     this.Hide();    // hide this form 

                 } // caher acc
                  else
                  {
                      MessageBox.Show("user name or password incorrect", "error", MessageBoxButtons.OK);
                      textBox1_username.Clear();
                      textBox2_password.Clear();

                     MessageBox.Show(querpass + querusername);

                  }

              }
              catch (Exception )
              {



                      MessageBox.Show("error", "error", MessageBoxButtons.OK);


              }
              //     finally
              //    {
              //         conn.Close();
              //    }
          }

             


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

       
    }
}

*/