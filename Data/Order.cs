using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CheckReport
{
    public class Order
    {
        public int Id { get; set; }
       public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }
        public virtual List<ProductInOrder> ProductInOrders { get; set; } = new List<ProductInOrder>();

        public void Save(StreamWriter writer)
        {
            writer.WriteLine("------------------");
            writer.WriteLine($"Заказ {Customer} от {DateTime}, {ProductInOrders.Count} товаров:");
            foreach (var productInOrder in ProductInOrders)
            {
                productInOrder.Save(writer);
            }
            writer.WriteLine();
            
        }
    }
}