using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EFPerformanceComparison.Core.Tests
{
    public class LoadAllBooksWithAuthorsNoTrackingTest
    {

        private readonly IUnitOfWork _unitOfWork;

        public LoadAllBooksWithAuthorsNoTrackingTest(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Book> LoadAllBooksWithAuthorsNoTracking()
        {
            return _unitOfWork.BookRepository().GetUntrackedQueryableIncAuthors().ToList();
        }
    }
}
