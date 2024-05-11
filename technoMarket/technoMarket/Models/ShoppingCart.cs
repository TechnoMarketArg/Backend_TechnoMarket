namespace technoMarket.Models
{
    public class ShoppingCart
    {
        public int UserId { get; set; }

        public HashSet<Product> Products { get; set; }

    }
}
