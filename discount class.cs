using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{


    internal class discount_class
    {
        private int discount_id;
        private double discount_percent;

        public discount_class()
        {
            this.discount_id = 0;
            this.discount_percent = 0;
        }
        public discount_class(int discountid, double discountpercent)
        {
            this.discount_id = discountid;
            this.discount_percent = discountpercent;
        }
        public int did
        {
            get { return discount_id; }
            set { discount_id = value; }

        }
        public double dpercent
        {
            get { return discount_percent; }
            set { discount_percent = value; }

        }
    }
}
