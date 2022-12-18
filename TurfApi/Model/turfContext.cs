using Microsoft.EntityFrameworkCore;

namespace TurfApi.Model
{
    public class turfContext : DbContext
    {
        public turfContext(DbContextOptions<turfContext> options) : base(options)
        {

        }
        public DbSet<turf> TurfItems { get; set; } = null!;
    }
}
