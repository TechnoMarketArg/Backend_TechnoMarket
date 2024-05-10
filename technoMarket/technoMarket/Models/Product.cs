namespace technoMarket.Models
{
    public class Product
    {
        public int Id { get; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; } 

        public string[] Images { get; set; }

        public object Category { get; set; } 

        public float Rating { get; set; }

    }
}
