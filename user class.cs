using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    internal class user_class
    {

        // user info declaration
        private int user_id;
        private int staff_id;
        private string user_name;
        private string password;
        private string user_type;

        public user_class() {

            this.user_id = 0;
            this.staff_id = 0;
            this.user_name = " ";
            this.password = " ";
            this.user_type = " ";
        }
        public user_class(int userid, int staffid, string username, // user info
            string pass, string usertype)
        {
            this.user_id = userid;
            this.staff_id = staffid;
            this.user_name = username;
            this.password = pass;
            this.user_type = usertype;
        } // user info

        public int uid
        {
            get { return user_id; }
            set { user_id = value; }
        }
        public int staff
        {
            get { return staff_id; }
            set { staff_id = value; }
        }
        public string username
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string userpas
        {
            get { return password; }
            set { password = value; }
        }

        public string utype
        {
            get { return user_type; }
            set { user_type = value; }
        }
    }
}
