namespace Domain.Models
{
    public class KiloWattPrice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd{ get; set; }
        public KiloWattPrice(Guid id, double price, string name, DateTime timeStart, DateTime timeEnd)
        {
            Id = id;
            Name = name;
            Price = price;
            TimeStart = timeStart;
            TimeEnd = timeEnd;  
        }
    }
}
