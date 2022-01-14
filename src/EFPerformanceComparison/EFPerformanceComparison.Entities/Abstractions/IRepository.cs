using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFPerformanceComparison.Core.Abstractions
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetQueryable();

        IQueryable<T> GetUntrackedQueryable();

        void Add(T entity);

        T First();

        void Remove(T entity);

        void AddRange(IEnumerable<T> entities);

        void RemoveRange(IEnumerable<T> entities);
    }
}
