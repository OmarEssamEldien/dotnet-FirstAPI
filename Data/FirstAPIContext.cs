using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Moby-Dick",
                    Author = "Herman Melvile",
                    YearPublished = 1851
                },
                new Book
                {
                    Id = 2,
                    Title = "Another Book",
                    Author = "Agatha Christy",
                    YearPublished = 1942
                },
                new Book
                {
                    Id = 3,
                    Title = "One More Book",
                    Author = "Herman Melvile",
                    YearPublished = 1851
                }
                );
        }

        public DbSet<Book> Books { get; set; }
    }
}
