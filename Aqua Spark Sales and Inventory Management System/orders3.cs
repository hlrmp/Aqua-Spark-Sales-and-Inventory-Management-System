﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class orders3 : Form
    {
        public orders3()
        {
            InitializeComponent();
            seecustomers();
            seeitems();
        }
        connection_class cc = new connection_class();

        private void button8_Click(object sender, EventArgs e) // ADD BUTTON 
        {


        } // ADD BUTTON 


        public void seecustomers()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            try
            {
                string str = "SELECT CONCAT(first_name, ' ', last_name) AS 'Customer Name' FROM customer ";
                SqlCommand cmd = new SqlCommand(str, sqlc);
                cmd.CommandText = str;
                sqlc.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    comboBox3.Items.Add(drd["product_name"].ToString());


                }
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


        public void seeitems()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            try
            {
                string str = "select product_name from products";
                SqlCommand cmd = new SqlCommand(str, sqlc);
                cmd.CommandText = str;
                sqlc.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    comboBox1.Items.Add(drd["product_name"].ToString());

                 
                }
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