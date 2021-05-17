using System;
using System.Collections.Generic;

namespace CheckReport
{
    public class Order
    {
        public int Id { get; set; }
       public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }
        public virtual List<ProductInOrder> ProductInOrders { get; set; }
    }
}