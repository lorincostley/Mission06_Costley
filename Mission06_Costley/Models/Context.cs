using Microsoft.EntityFrameworkCore;

namespace Mission06_Costley.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

               new Category { CategoryId = 1, CategoryName = "Thriller" },
               new Category { CategoryId = 2, CategoryName = "Horror" },
               new Category { CategoryId = 3, CategoryName = "Action" }

                );
        }
    }
}
