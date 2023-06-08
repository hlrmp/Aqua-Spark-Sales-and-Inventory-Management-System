using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    internal class orders_class
    {
        private int order_id;
        private int product_id;
        private int quantity;

        public orders_class()
        {
            this.order_id = 0;
            this.product_id = 0;
            this.quantity = 0;
        }
        public orders_class(int orderid, int productid, int quan)
        {  
            this.order_id = orderid;
            this.product_id = productid;
            this.quantity = quan;
        }   

        public int oid
        {
            get { return order_id; }
            set { order_id = value; }
        }

        public int pid
        {
            get { return product_id; }
            set { product_id = value; }
        }
        public int quanti
        {
            get { return quantity; }    
            set { quantity = value; }
        }
    }
}
