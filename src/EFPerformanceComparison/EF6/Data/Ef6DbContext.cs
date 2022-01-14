using EFPerformanceComparison.Core.Entities;
using System.Data.Entity;

namespace EFPerformanceComparison.EFSix.Data
{
    public class Ef6DbContext : DbContext
    {
        public Ef6DbContext() : base(@"Server=(localdb)\MSSQLLocalDB; Integrated Security=True; Database=EFPerformanceDB; MultipleActiveResultSets=true;")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Copy> Copy { get; set; }
    }
}
