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
                decimal productPrice = this.Discount * (this.PriceType == PriceType.Розничная
                    ? this.Product.RetailPrice
                    : this.Product.WholesalePrice);
                return this.ProductCount * productPrice;
            }
        }

        public void Save(StreamWriter writer)
        {
            writer.WriteLine($"{Product}, {ProductCount}, {PriceType}, {Discount}");
        }
    }
}