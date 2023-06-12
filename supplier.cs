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
            using (SqlConnection connect = new SqlConnection(cn.conn))
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
        }
    }
}
