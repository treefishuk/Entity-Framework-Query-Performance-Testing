using System;
using System.Collections.Generic;
using System.Text;

namespace EFPerformanceComparison.Core.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public string AuthorsName { get; set; }

    }
}
