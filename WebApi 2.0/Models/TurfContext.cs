using Microsoft.EntityFrameworkCore;

namespace WebApi_2._0.Models
{
    public class TurfContext : DbContext
    {
        public TurfContext(DbContextOptions<TurfContext> options)
        : base(options)
        {
        }

        public DbSet<Turf> TodoItems { get; set; } = null!;
    }
}
