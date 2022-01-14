using EFPerformanceComparison.Core.Entities;

namespace EFPerformanceComparison.Core.Abstractions
{
    public interface IUnitOfWork
    {

        IRepository<Author> AuthorRepository();

        IBookRepository BookRepository();

        IRepository<Copy> CopyRepository();

        void SaveChanges();

    }
}
