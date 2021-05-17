using System.IO;

namespace CheckReport
{
    public class ProductInOrder
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }
        
        public Product Product { get; set; }
        public int ProductId { get; set; }
        
        public int ProductCount { get; set; }

        public void Save(StreamWriter writer)
        {
            writer.WriteLine($"Товар: {Product}, количество: {ProductCount}");
        }
    }
}