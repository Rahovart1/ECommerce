using ECommerceAPI.Application.Interfaces;
using ECommerceAPI.Domain.Entities.Abstract;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry  = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }
        public async Task<bool> AddAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }
        public bool Remove(T entities)
        {
            EntityEntry<T> entityEntry = Table.Remove(entities);
            return entityEntry.State == EntityState.Deleted;

        } 
        public bool Remove(List<T> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }
        public async Task<bool> RemoveAsync(string id)
        {
            T entity = await Table.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
            return Remove(entity);
        }

        public bool Update(T entity)
        {
            EntityEntry entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync(T entity) => await _context.SaveChangesAsync();

    }
}
