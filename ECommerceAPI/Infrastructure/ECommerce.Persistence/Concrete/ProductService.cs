using ECommerceAPI.Application.Interfaces;
using ECommerceAPI.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() =>
            new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product1", Price = 100, Stock = 10},
                new() { Id = Guid.NewGuid(), Name = "Product2", Price = 100, Stock = 10},
                new() { Id = Guid.NewGuid(), Name = "Product3", Price = 100, Stock = 10},
                new() { Id = Guid.NewGuid(), Name = "Product4", Price = 100, Stock = 10},
                new() { Id = Guid.NewGuid(), Name = "Product5", Price = 100, Stock = 10}
            };
    }
}
