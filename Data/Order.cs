using System;
using System.Collections.Generic;
using System.IO;

namespace CheckReport
{

    public enum OrderType
    {
        Приход=0,
        Реализация=1,
        Списание=2
    }

    public class Order
    {
        public int Id { get; set; }
       public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }
        
        public string Comment { get; set; }
        
        public OrderType Type { get; set; }
        
        public virtual List<ProductInOrder> ProductInOrders { get; set; } = new List<ProductInOrder>();

        private decimal CalculatePrice()
        {
            decimal price = 0;
            foreach (var productInOrder in ProductInOrders)
            {
                price += productInOrder.Price;
            }

            return price;
        }
        public void Save(StreamWriter writer)
        {
            writer.WriteLine("------------------");
            writer.WriteLine($"Заказ {Customer} от {DateTime} на сумму :{this.CalculatePrice()}, {ProductInOrders.Count} товаров:");
            foreach (var productInOrder in ProductInOrders)
            {
                productInOrder.Save(writer);
            }
            writer.WriteLine();
            
        }
    }
}