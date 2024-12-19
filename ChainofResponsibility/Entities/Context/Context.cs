using Microsoft.EntityFrameworkCore;

namespace ChainofResponsibility.Entities.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ChainofResponsibility;trusted_connection=true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
