namespace technoMarket.Models
{
    public class User
    {
        public int Id { get; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        //public string Password { get; set; }

        public bool Trader { get; set; } = false;

        public bool Active { get; set; } 


    }
}
