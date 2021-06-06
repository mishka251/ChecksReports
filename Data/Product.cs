using System.Collections.Generic;

namespace CheckReport
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Розничная цена
        /// </summary>
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// Оптовая цена
        /// </summary>
        public decimal WholesalePrice { get; set; }

        public ProductGroup Group { get; set; }

        public TradeDepartment Department { get; set; }

        public string Unit { get; set; }

        public string Country { get; set; }


        public virtual List<ProductInOrder> ProductInOrders { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public int Count
        {
            get
            {
                int count = 0;
                if (this.ProductInOrders == null)
                {
                    return count;
                }
                foreach (var order in ProductInOrders)
                {
                    if (order.Order.Type == OrderType.Incoming)
                    {
                        count += order.ProductCount;
                    }

                    else
                    {
                        count -= order.ProductCount;
                    }
                }

                return count;
            }
        }
    }
}