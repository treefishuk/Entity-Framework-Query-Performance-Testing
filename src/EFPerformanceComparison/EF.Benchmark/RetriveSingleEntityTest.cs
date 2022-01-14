using BenchmarkDotNet.Attributes;
using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;
using System.Linq;

namespace EFPerformanceComparison.Core.Tests
{
    public class RetriveSingleEntityTest
    {

        private readonly IUnitOfWork _unitOfWork;

        public RetriveSingleEntityTest(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Book FirstOrDefault() => _unitOfWork.BookRepository().First();

    }
}
