using Microsoft.EntityFrameworkCore;

namespace Mission06_Costley.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
