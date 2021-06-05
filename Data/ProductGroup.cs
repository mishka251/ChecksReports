namespace CheckReport
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public override string ToString()
        {
            return this.Name;
        }
    }
}