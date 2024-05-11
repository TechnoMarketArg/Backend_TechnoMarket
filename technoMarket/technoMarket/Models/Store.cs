namespace technoMarket.Models
{
    public class Store
    {
        public int Id { get; set; } 

        public virtual User Owner { get; set; } 

        public string Name { get; set; } 

        public string Description { get; set; }

        public bool Active { get; set; }

        public HashSet<int> Inventory { get; set; } = new HashSet<int>();

        public List<int> ProductsSold { get; set; } = new List<int>();

        public decimal Ranking { get; set; } = 0;
    }
    
}
