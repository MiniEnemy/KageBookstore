using Microsoft.EntityFrameworkCore;
using My_bookStore.Models;

namespace My_bookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) // creating category table

        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // inserting data in category table
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 3, Name = "Drama", Displayorder = 3 },
                new Category { Id = 1, Name = "Action", Displayorder = 1 },
                new Category { Id = 2, Name = "Sci-fi", Displayorder = 2 },
                new Category { Id = 4, Name = "Romance", Displayorder = 4 }
                );
        }



    }
   

}
