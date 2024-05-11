using System.Data;

namespace technoMarket.Models
{
    public class User
    {
        public int Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; } = true;

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual Store Stores { get; set; }

        public List<int> ProductsPurchased { get; set; } = new List<int>();

        public HashSet<int> ProductsFavorites { get; set; } = new HashSet<int>();

        public HashSet<int> StoreFavotires { get; set; } = new HashSet<int>();

        public User() 
        { 
            Roles = new HashSet<Role>();
            Roles.Add(new Role( 3, "Customer"));
        }

    }
}
