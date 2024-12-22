using Factory.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Factory.DAL.Context
{
    public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Electronic> Electronics { get; set; }
        public DbSet<Clothing> Clothing { get; set; }
        public DbSet<Food> Food { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
