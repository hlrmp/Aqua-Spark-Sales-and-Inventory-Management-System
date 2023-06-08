using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;

namespace Aqua_Spark
{
    internal class connection_class
    {
        public string data_connection()
        {
            string conn = "@Data Source=LAPTOP-3JRG23SL;Initial Catalog=aquasparkdata;Integrated Security=True ";
            return conn;

        }
     
      
    }
}  

  

