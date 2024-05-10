namespace technoMarket.Models
{
    public class MarketPlace
    {
        public int Id { get; set; }

        public int IdShopper { get; set; } 

        public int IdTrader { get; set; }

        public string[] IdProducts { get; set; }

        public DateTime DateTime { get; set; }

        public bool State { get; set; }

    }
}
 