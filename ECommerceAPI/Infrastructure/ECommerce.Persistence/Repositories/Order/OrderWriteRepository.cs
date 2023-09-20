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
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
