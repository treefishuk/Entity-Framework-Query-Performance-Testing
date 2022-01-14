using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EFPerformanceComparison.Core.Tests
{
    public class LoadAllBooksWithAuthorsBenchmarkTest
    {

        private readonly IUnitOfWork _unitOfWork;

        public LoadAllBooksWithAuthorsBenchmarkTest(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Book> LoadAllBooksWithAuthors()
        {
            return _unitOfWork.BookRepository().GetQueryableIncAuthors().ToList();
        }

    }
}
