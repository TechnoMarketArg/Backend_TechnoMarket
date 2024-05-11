namespace technoMarket.Models
{
    public class Reviews
    {
        public int Id { get; set; }

        public int CustomerId { get; }

        public int ProductId { get; }

        public string Comment { get; }

        public decimal Rating { get; }

    }
}
