using Microsoft.EntityFrameworkCore;
using My_bookStore.Models;

namespace My_bookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)

        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

    }
   

}
