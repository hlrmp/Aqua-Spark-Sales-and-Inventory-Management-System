using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    // user info declaration
  
    internal class customer_class
    {
        private int customer_id;
        private string first_name;
        private string last_name;
        private string address;
        private int contact_number;
        private string email;

        public customer_class()
        {
            this.customer_id = 0;
            this.first_name = " ";
            this.last_name = " ";
            this.address = " ";
            this.contact_number = 0;
            this.email = " ";
        }
        public customer_class(int customerid, string firstname, string lastname, string add,  string em)
        {
            this.customer_id = customerid;
            this.first_name = firstname;
            this.last_name = lastname;
            this.address = add;
            this.contact_number = 0;
            this.email = em;

        }

        public int id  // 1 encapsulation customer info
        {
            get { return customer_id; }
            set { customer_id = value; }
        }
        public string ftname
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string lname
        {
            get { return last_name; }
            set { last_name = value; }

        }
        public string addr
        {
            get { return address; }
            set { address = value; }
        }
        public int contacnum
        {
            get { return contact_number; }
            set { contact_number = value; }
        }
        public string e
        {
            get { return email; }
            set { email = value; }
        }
    }
}
