namespace Citizens_and_Cars.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public int Gear { get; set; }

        public List<Citizen> Citizens { get; set; }
    }
}