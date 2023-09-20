﻿using ECommerceAPI.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Interfaces
{
    public interface IOrderWriteRepository : IWriteRepository<Order>
    {
    }
}
