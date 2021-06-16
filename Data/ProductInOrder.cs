using System.IO;

namespace CheckReport
{
    /// <summary>
    /// Тип цены
    /// Розничная - розница
    /// Оптовая - оптовая
    /// </summary>
    public enum PriceType
    {
        Розничная = 0,
        Оптовая = 1,
    }

    public class ProductInOrder
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public int ProductCount { get; set; }

        public PriceType PriceType { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public decimal Discount { get; set; }


        public decimal Price
        {
            get
            {
                decimal productPrice = (this.PriceType == PriceType.Розничная
                    ? this.Product.RetailPrice
                    : this.Product.WholesalePrice);
                return this.ProductCount * productPrice*((decimal)1-this.Discount/100);
            }
        }

        public void Save(StreamWriter writer)
        {
            decimal priceValue = PriceType == PriceType.Оптовая ? Product.WholesalePrice : Product.RetailPrice;
            writer.WriteLine($"{Product}; {ProductCount}; {PriceType}; {priceValue}; {Discount}; {Price}");
        }
    }
}