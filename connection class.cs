using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Aqua_Spark_Sales_and_Inventory_Management_System { 
    internal class connection_class
    {
          public string conn = @"Data Source=LAPTOP-3JRG23SL;Initial Catalog=aquasparkdata;Integrated Security=True ; Encrypt = false";
      //  public string conn = @"Data Source=REICHEL28\SQLEXPRESS01;Initial Catalog=aquasparkdata;Integrated Security=True ; Encrypt = false";
        
        public connection_class()
        {
        

        }
      
     
      
    }
}  

  

