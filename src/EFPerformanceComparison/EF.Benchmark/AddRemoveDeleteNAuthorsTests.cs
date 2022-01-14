using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFPerformanceComparison.Core.Tests
{
    public class AddRemoveDeleteNAuthorsTests
    {
        const int N = 2500;

        private readonly IUnitOfWork _unitOfWork;

        public AddRemoveDeleteNAuthorsTests(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddNAuthors()
        {
            var authors = new List<Author>();
            for (int i = 0; i < N; i++)
            {
                authors.Add(new Author()
                {
                    FullName = "New Author " + i
                });
            }

            _unitOfWork.AuthorRepository().AddRange(authors);

            _unitOfWork.SaveChanges();
        }

        public void LoadAndUpdateNAuthors()
        {
            foreach (var author in _unitOfWork.AuthorRepository().GetQueryable().Take(N))
            {
                author.FullName = DateTime.Now.ToString();
            }

            _unitOfWork.SaveChanges();
        }

        public void LoadAndDeleteNAuthors()
        {
            var authors = _unitOfWork.AuthorRepository().GetQueryable()
                .Where(author => author.FullName.StartsWith("New Author"))
                .Take(N)
                .ToList();

            _unitOfWork.AuthorRepository().RemoveRange(authors);
            _unitOfWork.SaveChanges();
        }
    }
}
