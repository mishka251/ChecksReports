using System.Collections.Generic;

namespace CheckReport
{
    public class Product
    {
        public int Id { get; set; }
        public string VendorCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public virtual List<ProductInOrder> ProductInOrders { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}