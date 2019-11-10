using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySimpleECommerce.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;

        protected Repository(DbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(T entity) => Context.Set<T>().Add(entity);

        public void AddRange(IEnumerable<T> entities) => Context.Set<T>().AddRange(entities);

        public T Find(Guid id) => Context.Set<T>().Find(id);

        public IEnumerable<T> GetAll() => Context.Set<T>().ToList();

        public IEnumerable<T> GetAllNoTracking() => Context.Set<T>().AsNoTracking().ToList();

        public void Remove(T entity) => Context.Set<T>().Remove(entity);

        public void RemoveAddRange(IEnumerable<T> entities) => Context.Set<T>().RemoveRange(entities);
    }
}
