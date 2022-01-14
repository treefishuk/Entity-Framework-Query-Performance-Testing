using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Entities;
using System;
using System.Linq;

namespace EFPerformanceComparison.Core.Tests
{
    public class AddRemoveAndDeleteRecordTests
    {

        private readonly IUnitOfWork _unitOfWork;

        public AddRemoveAndDeleteRecordTests(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add()
        {
            var newAuthor = new Author()
            {
                FullName = "Adding Author with EF6"
            };

            _unitOfWork.AuthorRepository().Add(newAuthor);

            _unitOfWork.SaveChanges();
        }

        public void Update()
        {
            var authorToUpdate = _unitOfWork.AuthorRepository().First();

            authorToUpdate.FullName = DateTime.Now.ToString();

            _unitOfWork.SaveChanges();
        }

         public void Delete()
        {
            var authorToDelete = _unitOfWork.AuthorRepository().GetQueryable()
                .Where(author => author.FullName == "Adding Author")
                .FirstOrDefault();

            _unitOfWork.AuthorRepository().Remove(authorToDelete);

            _unitOfWork.SaveChanges();
        }
    }
}
