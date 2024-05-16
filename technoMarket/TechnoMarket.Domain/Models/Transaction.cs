using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoMarket.Domain.Models
{
    public class Transaction
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
