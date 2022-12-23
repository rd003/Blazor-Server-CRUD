using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
