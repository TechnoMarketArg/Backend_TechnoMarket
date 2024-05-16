using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoMarket.Domain.Models
{
    public class ShoppingCart
    {
        public int UserId { get; set; }

        public HashSet<Product> Products { get; set; }
    }
}
