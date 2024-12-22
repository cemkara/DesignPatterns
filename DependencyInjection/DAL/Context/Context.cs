using DependencyInjection.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjection.DAL.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DP_DependencyInjection;trusted_connection=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
