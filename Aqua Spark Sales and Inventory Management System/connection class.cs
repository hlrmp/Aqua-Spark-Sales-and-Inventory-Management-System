using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    internal class connection_class
    {

        public string cn(string connection)
        {
             connection = "Data Source=LAPTOP-3JRG23SL;Initial Catalog=aquasparkdata;Integrated Security=True";

            return connection;

        }
    }


}
