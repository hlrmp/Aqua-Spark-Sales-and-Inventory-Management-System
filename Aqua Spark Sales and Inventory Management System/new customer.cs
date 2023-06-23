using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class new_customer : Form
    {
        public new_customer()
        {
            InitializeComponent();
        }
        customer_class cs = new customer_class();
        connection_class ss = new connection_class();
        private void button2_Click(object sender, EventArgs e) // cancel button
        {
            textBoxfname.Clear();
            textBoxlname.Clear();
            textBoxaddress.Clear();
            textBoxcontactno.Clear();
            textBoxemail.Clear();

            this.Hide();

        }// cancel button

        private void button3_Click(object sender, EventArgs e) // clear buton 
        {
            textBoxfname.Clear();
            textBoxlname.Clear();
            textBoxaddress.Clear();
            textBoxcontactno.Clear();
            textBoxemail.Clear();

        } // clear button

        private void button1_Click(object sender, EventArgs e) // add bbutton
        {



            add();

            textBoxlname.Clear();
            textBoxfname.Clear();
            textBoxaddress.Clear();
            textBoxcontactno.Clear();
            textBoxemail.Clear();


        }// add bbutton


        public void add()
        {

      //      try
       ///     {



                using (SqlConnection cnn = new SqlConnection(ss.conn))
                {

                    if (!string.IsNullOrEmpty(textBoxlname.Text) || !string.IsNullOrEmpty(textBoxfname.Text) || !string.IsNullOrEmpty(textBoxaddress.Text) || !string.IsNullOrEmpty(textBoxcontactno.Text) || !string.IsNullOrEmpty(textBoxemail.Text))
                    {
                        cnn.Open();
                        string day = DateTime.Now.ToString("M/d/yyyy");
                        string quer1 = "INSERT INTO customer(first_name,last_name,address,contact_number,email)values(@first_name,@last_name,@address,@contact_number,@email)";
                        SqlCommand command = new SqlCommand(quer1, cnn);

                        command.Parameters.AddWithValue("@first_name", textBoxfname.Text);
                        command.Parameters.AddWithValue("@last_name", textBoxlname.Text);
                        command.Parameters.AddWithValue("@address", textBoxaddress.Text);
                        command.Parameters.AddWithValue("@contact_number", textBoxcontactno.Text);
                        command.Parameters.AddWithValue("@email", textBoxemail.Text);
                        command.ExecuteNonQuery();



                    }
                    else   
                    {
                        MessageBox.Show(" fill up the ff.");
                    }




                }


          //  }
            //catch
            
            
            //{
             //   MessageBox.Show("Error ");
            //}




        }


    }
}


