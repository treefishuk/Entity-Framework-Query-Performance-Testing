using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.DTOs;
using EFPerformanceComparison.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EFPerformanceComparison.Core.Tests
{
    public class SortingTests
    {

        private readonly IUnitOfWork _unitOfWork;

        public SortingTests(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Book> LoadAllBooksOrderedByAuthor()
        {
            return _unitOfWork.BookRepository().GetQueryableIncAuthors().OrderBy(x => x.Author.FullName).ToList();
        }

        public List<BookDTO> LoadAllBooksOrderedByAuthorProjection()
        {
            return _unitOfWork.BookRepository()
                .GetQueryable()
                .Select(s => new BookDTO
                {
                    Id = s.BookId,
                    Title = s.Name,
                    AuthorId = s.AuthorId,
                    AuthorsName = s.Author.FullName
                }).OrderBy(x => x.AuthorsName).ToList();
        }

        public List<BookDTO> LoadAllBooksOrderedByAuthorProjectionUntracked()
        {
            return _unitOfWork.BookRepository()
                .GetUntrackedQueryable()
                .Select(s => new BookDTO
                {
                    Id = s.BookId,
                    Title = s.Name,
                    AuthorId = s.AuthorId,
                    AuthorsName = s.Author.FullName
                }).OrderBy(x => x.AuthorsName).ToList();
        }

    }
}
