using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoMarket.Domain.Models
{
    public class Role
    {
        public int Id { get; set; }  //0: Super-admin - 1: Admin - 2: Seller - 3: Customer
        public string Name { get; set; }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
