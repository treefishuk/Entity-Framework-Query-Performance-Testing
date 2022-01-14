using EFPerformanceComparison.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFPerformanceComparison.EFCoreSix.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EfCoreSixDbContext Context;

        public Repository(EfCoreSixDbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Context.AddRange(entities);
        }

        public T First()
        {
            return Context.Set<T>().FirstOrDefault();
        }

        public IQueryable<T> GetQueryable()
        {
            return Context.Set<T>();
        }

        public IQueryable<T> GetUntrackedQueryable()
        {
            return Context.Set<T>().AsNoTracking();
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }
    }
}
