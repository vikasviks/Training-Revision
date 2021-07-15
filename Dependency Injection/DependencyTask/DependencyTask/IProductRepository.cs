using DependencyTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyTask
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
    }
}
