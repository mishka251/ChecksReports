namespace CheckReport
{
    public class Customer
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }

        public string INN { get; set; }

        public string OKPO { get; set; }

        public string KPP { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Status { get; set; }

        public TradeDepartment Department { get; set; }

        public override string ToString()
        {
            return this.ShortName;
        }
    }
}