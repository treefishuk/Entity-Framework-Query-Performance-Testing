using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;
using System.Data.Entity;
using System.Linq;

namespace EFPerformanceComparison.EFSix.Data
{
    public class BookRepository : Repository<Book>, IBookRepository
    {

        public BookRepository(Ef6DbContext context) : base(context)
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
