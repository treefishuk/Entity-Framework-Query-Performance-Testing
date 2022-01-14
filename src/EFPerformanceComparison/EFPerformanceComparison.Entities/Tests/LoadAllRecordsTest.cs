using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.DTOs;
using EFPerformanceComparison.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EFPerformanceComparison.Core.Tests
{
    public class LoadAllRecordsTest
    {

        private readonly IUnitOfWork _unitOfWork;

        public LoadAllRecordsTest(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Book> LoadAllBooks()
        {
            return _unitOfWork.BookRepository().GetQueryable().ToList();
        }

        public List<Book> LoadAllBooksUntracked()
        {
            return _unitOfWork.BookRepository().GetUntrackedQueryable().ToList();
        }

        public List<Book> LoadAllBooksWithAuthor()
        {
            return _unitOfWork.BookRepository().GetQueryableIncAuthors().ToList();
        }

        public List<BookDTO> LoadAllBooksWithAuthorProjection()
        {
            return _unitOfWork.BookRepository()
                .GetQueryable()
                .Select(s => new BookDTO
                {
                    Id = s.BookId,
                    Title = s.Name,
                    AuthorId = s.AuthorId,
                    AuthorsName = s.Author.FullName
                }).ToList();
        }

        public List<BookDTO> LoadAllBooksWithAuthorProjectionUntracked()
        {
            return _unitOfWork.BookRepository()
                .GetUntrackedQueryable()
                .Select(s => new BookDTO
                {
                    Id = s.BookId,
                    Title = s.Name,
                    AuthorId = s.AuthorId,
                    AuthorsName = s.Author.FullName
                }).ToList();
        }

    }
}
