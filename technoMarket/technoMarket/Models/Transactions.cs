namespace technoMarket.Models
{
    public class Transactions
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public int CustomerId { get; set; }

        public List<int> ProductsId { get; set; }

        public decimal totalFee { get; set; }

        public bool Status { get; set; } = false;

        public DateTime DateTransaction { get; set; } = DateTime.Now;

    }
}
