using ECommerceAPI.Application.Interfaces;
using ECommerceAPI.Domain.Entities.Concrete;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
