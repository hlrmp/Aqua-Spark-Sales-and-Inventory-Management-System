﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class user_setup : Form
    {
        public user_setup()
        {
            InitializeComponent();
            list();
        }

        connection_class scn = new connection_class();

        public void list()
        {
            ArrayList clist = new ArrayList();

            clist.Add(" manager ");
            clist.Add(" cashier ");

            foreach (string pos in clist)
            {
                comboBox1.Items.Add(pos);
            } 

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)     // password show
        {
            if (checkBox1.Checked == true)
            {
                textBox2_password.UseSystemPasswordChar = false;
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {

                textBox2_password.UseSystemPasswordChar = true;
                textBox1.UseSystemPasswordChar = true;
            }
        }    // password show

        private void button3_Click(object sender, EventArgs e) // clear button
        {
            textBox1_username.Clear();
            textBox2_password.Clear();

        }// clear button

        string position;

        private void button1_Click(object sender, EventArgs e)
        {
            position = comboBox1.Text;

            if (!string.IsNullOrEmpty(textBox1_username.Text) && !string.IsNullOrEmpty(textBox2_password.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                if (textBox2_password == textBox1)
                {

                }
                else
                {

                }
            }
            else
            {

            }
        }

        public void pass()
        {
            supplier s = new supplier();

            try
            {



                using (SqlConnection cnn = new SqlConnection(scn.conn))
                {
                    cnn.Open();
                    string quer = "   INSERT INTO users (staff_id ,username,password,user_type ) VALUES((select staff_id  FROM staffs where first_name = '" + s.fn + "' and last_name = '" + s.ln + "') ,@username,@password,@user_type )";

                    //  string quer1 = " INSERT INTO staffs (first_name ,last_name,email,contact_number ) VALUES ('" + textBoxfname + "' ,'" + textBoxlname + "','" + textBoxcontactno + "','" + textBoxemail + "')";
                    //  SqlCommand cmm = new SqlCommand(quer1, cnn);
                    SqlCommand command = new SqlCommand(quer, cnn);

                    command.Parameters.AddWithValue("@username", textBox1_username.Text);
                    command.Parameters.AddWithValue("@password", textBox2_password.Text);
                    command.Parameters.AddWithValue("@user_type", position);


                    command.ExecuteNonQuery();

                    cnn.Close();


                }




            }
            catch
            {
                MessageBox.Show("Error ");
            }




        }

    }
}

