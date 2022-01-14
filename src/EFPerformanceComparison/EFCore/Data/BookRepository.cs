using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFPerformanceComparison.EFCoreThree.Data
{
    public class BookRepository : Repository<Book>, IBookRepository
    {

        public BookRepository(EfCoreThreeDbContext context) : base(context)
        {
        }

        public IQueryable<Book> GetQueryableIncAuthors()
        {
            return Context.Set<Book>().Include(i => i.Author);
        }

        public IQueryable<Book> GetUntrackedQueryableIncAuthors()
        {
            return Context.Set<Book>().Include(i => i.Author).AsNoTracking();
        }
    }
}
