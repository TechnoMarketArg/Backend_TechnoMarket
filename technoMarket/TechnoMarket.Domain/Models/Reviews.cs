using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoMarket.Domain.Models
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
