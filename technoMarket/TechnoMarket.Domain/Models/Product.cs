using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoMarket.Domain.Models
{
    public class Product
    {
        public int Id { get; }

        public int StoreId { get; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public List<string> Images { get; set; }

        public object Category { get; set; }

        public decimal Rating { get; } = 0;

        public DateTime postedDate { get; } = DateTime.Now;
    }
}
