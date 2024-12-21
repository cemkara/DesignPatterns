using Microsoft.EntityFrameworkCore;

namespace Singleton.Entities.Context
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Log> Logs { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

    }
}
