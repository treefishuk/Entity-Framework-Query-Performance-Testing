using EFPerformanceComparison.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFPerformanceComparison.Core.Abstractions
{
    public interface IBookRepository : IRepository<Book>
    {
        IQueryable<Book> GetQueryableIncAuthors();

        IQueryable<Book> GetUntrackedQueryableIncAuthors();

    }
}
