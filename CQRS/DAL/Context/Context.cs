using Microsoft.EntityFrameworkCore;

namespace CQRS.DAL.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DP_CQRS;trusted_connection=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
