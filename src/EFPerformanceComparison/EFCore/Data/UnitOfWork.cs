using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;

namespace EFPerformanceComparison.EFCoreThree.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly EfCoreThreeDbContext _context;

        public UnitOfWork()
        {
            _context = new EfCoreThreeDbContext();
        }

        public IRepository<Author> AuthorRepository()
        {
            return new Repository<Author>(_context);
        }

        public IBookRepository BookRepository()
        {
            return new BookRepository(_context);
        }

        public IRepository<Copy> CopyRepository()
        {
            return new Repository<Copy>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
