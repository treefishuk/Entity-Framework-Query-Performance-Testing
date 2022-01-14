using EFPerformanceComparison.Core.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace EFPerformanceComparison.EFSix.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Ef6DbContext Context;

        public Repository(Ef6DbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
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
