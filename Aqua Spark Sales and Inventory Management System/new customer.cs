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



            addsup();

            textBoxlname.Clear();
            textBoxfname.Clear();
            textBoxaddress.Clear();
            textBoxcontactno.Clear();
            textBoxemail.Clear();


        }// add bbutton


        public void addsup()
        {
            //  string txtlname = textBoxlname.Text;
            //string txtfname = textBoxfname.Text;
            /// string txtadd = textBoxaddress.Text;
            // string txtaddress = textBoxaddress.Text;
            // int txtcon = Convert.ToInt32(textBoxcontactno.Text);
            // string txte = textBoxemail.Text;
            try
            {

                //  cs.lname = txtlname;
                //  cs.ftname = txtlname;
                //   cs.addr = txtadd;
                //   cs.contacnum = txtcon;
                //   cs.e = txte;


                using (SqlConnection cnn = new SqlConnection(ss.conn))
                {
                    cnn.Open();
                    //    string quer = " INSERT INTO customer (first_name ,last_name,address,contact_number,email ) VALUES (@first_name ,@last_name,@address,@contact_number,@email)";
                    

                    string quer1 = " INSERT INTO customer (first_name ,last_name,address,contact_number,email ) VALUES ('" + textBoxfname + "' ,'" + textBoxlname + "','" + textBoxaddress + "','" + textBoxcontactno + "','" + textBoxemail + "')";
                    SqlCommand cmm = new SqlCommand(quer1, cnn);
                //    SqlCommand command = new SqlCommand(quer1, cnn);
                    // SqlDataAdapter dataAdapter = new SqlDataAdapter(cmm);
                    //   DataTable dt = new DataTable(quer1);
                    //     dt.Rows.Add(quer1,cnn); 
                    // dataAdapter.Fill(dt);

                    //  command.Parameters.AddWithValue("@first_name",textBoxfname.Text);
                    //   command.Parameters.AddWithValue("@last_name",textBoxlname.Text);
                    //  command.Parameters.AddWithValue("@address",textBoxaddress.Text);
                    //  command.Parameters.AddWithValue("@contact_number",Convert.ToInt32( textBoxcontactno.Text));
                    //  command.Parameters.AddWithValue("@email",textBoxemail.Text);
               //    cmm.ExecuteNonQuery();

                    cnn.Close();


                }


                //   sign_up Up = new sign_up();
                //  Up.Refresh();
                // this.Refresh();
                // this.Hide();



            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

    } 
}


