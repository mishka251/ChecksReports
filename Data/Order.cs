using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CheckReport
{

    public enum OrderType
    {
        Incoming=0,//приход
        Selling=1,//реализация
        WriteOff=2//списание
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