using System.Collections.Generic;

namespace EFPerformanceComparison.Core.Entities
{
    public class Book
    {

        public int BookId { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public virtual IList<Copy> Copies { get; set; }
    }
}
