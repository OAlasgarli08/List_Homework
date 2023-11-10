using Practical.Data;
using Practical.Models;
using Practical.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Services
{
    internal class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }

        public List<Product> GetAllByDescending()
        {
            return AppDbContext.Products().OrderByDescending(m => m.Price).ToList();
        }

        public Product GetById(int id)
        {
            return AppDbContext.Products().FirstOrDefault(m => m.Id == id);
        }
    }
}
