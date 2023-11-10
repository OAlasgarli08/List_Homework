using Practical.Services;
using Practical.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Controllers
{
    internal class ProductController
    {
        private readonly IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }
        public void GetAll()
        {
            var datas = _productService.GetAll();
            foreach (var data in datas)
            {
                Console.WriteLine(data.Name + " ----  " + data.Price);
            }
        }

        public void GetById()
        {
            var data = _productService.GetById(2);
            Console.WriteLine(data.Name + " ----  " + data.Price);
        }

        public void Sorting()
        {
            var datas = _productService.GetAllByDescending();
            foreach (var data in datas)
            {
                Console.WriteLine(data.Name + " ----  " + data.Price);
            }
        }
    }
}
