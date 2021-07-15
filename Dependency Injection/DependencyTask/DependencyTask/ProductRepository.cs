using DependencyTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyTask
{
    public class ProductRepository:IProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "pen",
                Quantity = 100
            };
            products.Add(product);

            product = new Product()
            {
                ProductId = 2,
                ProductName = "pencil",
                Quantity = 200
            };
            products.Add(product);

            return products;
        }
    }
} 
