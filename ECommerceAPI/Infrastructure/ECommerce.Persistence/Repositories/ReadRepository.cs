using ECommerceAPI.Application.Interfaces;
using ECommerceAPI.Domain.Entities.Abstract;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public ReadRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();
            return await query.FirstOrDefaultAsync(t => t.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        } 

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();
            return query;
        }
    }
}
