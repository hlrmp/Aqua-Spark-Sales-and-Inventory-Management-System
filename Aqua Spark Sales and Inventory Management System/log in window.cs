﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class log_in_window : Form
    {
        public log_in_window()
        {
            InitializeComponent();

        }


        SqlConnection conn = new SqlConnection("Data Source=REICHEL28\\SQLEXPRESS01;Initial Catalog=db_form;Integrated Security=True");
        // (@"Data Source=REICHEL28\SQLEXPRESS01;Initial Catalog=db_form;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)   // log in button
        {


            if (textBox1_username.Text == "")
            {
                MessageBox.Show(" Enter your user name ");
            }
            else if (textBox2_password.Text == "")
            {
                MessageBox.Show(" Enter your password ");
            }
            else
            {
               

                try
                {

                    string username, password;

                    username = textBox1_username.Text;
                    password = textBox2_password.Text;


                    string quer = "SELECT * FROM log in WHERE user name = '" + textBox1_username.Text + "' AND password = '" + textBox2_password.Text + "'";
                    //  SqlDataAdapter sd = new SqlDataAdapter(quer,conn);

                    DataTable table = new DataTable(quer);
                    //sd.Fill(table);

                    //string querlognum = "SELECT * FROM log in WHERE lid IN('1')"; // user name and password 1 
                    //string querlognum2 = "SELECT * FROM log in WHERE lid IN('1')"; // user name and password 2
                    //   string queruser = " SELECT USER NAME FROM log in WHERE condition";

                    int c = 1;
                    int a = 1;

                    if (table.Rows.Count >= 0 )
                    {
                        username = textBox1_username.Text;
                        password = textBox2_password.Text;

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


                    }
                    else
                    {
                        MessageBox.Show("user name or password incorrect", "error", MessageBoxButtons.OK);
                        textBox1_username.Clear();
                        textBox2_password.Clear();

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








    }
}
