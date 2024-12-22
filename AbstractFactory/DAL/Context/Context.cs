using AbstractFactory.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.DAL.Context
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
