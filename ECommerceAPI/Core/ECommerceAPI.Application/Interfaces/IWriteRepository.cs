using ECommerceAPI.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Interfaces
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddAsync(List<T> entities);
        bool Remove(T entity);
        bool Remove(List<T> entities);
        Task<bool> RemoveAsync(string id);
        bool Update(T entity);
        Task<int> SaveAsync(T entity);
    }
}
