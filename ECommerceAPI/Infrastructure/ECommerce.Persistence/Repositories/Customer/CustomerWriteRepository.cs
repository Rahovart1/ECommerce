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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
