using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class customer2 : Form
    {
        public customer2()
        {
            InitializeComponent();
        }
        
        public int customer_id  // 1 encapsulation customer info
        {
            get; set;   
        }
        public string first_name
        {
            get; set;
        }
        public string last_name
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public string contact_number
        {
            get; set;
        }
        public string email
        {
            get; set;
        } // 1 encapsulation customer info
           

        private void button1_Click(object sender, EventArgs e) // home button 
        {
            Home_window hm1 = new Home_window();
            hm1.Show();
            this.Hide();

        }// home button 


    }
}
