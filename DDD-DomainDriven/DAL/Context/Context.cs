using Microsoft.EntityFrameworkCore;

namespace DDD_DomainDriven.DAL.Context
{
    public class Context:DbContext
    {
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<TrackingEvent> TrackingEvents { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
