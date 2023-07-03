using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<service> service { get; set; }

        public DbSet<details> details { get; set; }
        }
}
