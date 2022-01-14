using EFPerformanceComparison.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFPerformanceComparison.EFCoreSix.Data
{
    public class EfCoreSixDbContext : DbContext
    {
        public EfCoreSixDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Copy> Copy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
                .UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB; Integrated Security=True; Database=EFPerformanceDB; MultipleActiveResultSets=true;"
                );

    }
}
