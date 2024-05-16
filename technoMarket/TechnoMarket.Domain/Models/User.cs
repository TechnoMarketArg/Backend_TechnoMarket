﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TechnoMarket.Domain.Models
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

        public virtual Store Store { get; set; }

        public List<int> ProductsPurchased { get; set; } = new List<int>();

        public HashSet<int> ProductsFavorites { get; set; } = new HashSet<int>();

        public HashSet<int> StoresFavotires { get; set; } = new HashSet<int>();

        public User()
        {
            Roles = new HashSet<Role>();
            Roles.Add(new Role(3, "Customer"));
        }
    }
}