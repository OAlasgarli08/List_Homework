using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Data
{
    internal class AppDbContext
    {
        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product { Id = 1, Name = "A", Price = 15},
                 new Product { Id = 2, Name = "B", Price = 5},
                  new Product { Id = 3, Name = "C", Price = 10}
            };

        }
    }
}
