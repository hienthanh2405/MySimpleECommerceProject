using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleECommerce.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Find(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllNoTracking();
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveAddRange(IEnumerable<T> entities);
    }
}
