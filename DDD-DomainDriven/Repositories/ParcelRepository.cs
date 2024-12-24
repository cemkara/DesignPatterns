using DDD_DomainDriven.DAL;
using DDD_DomainDriven.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace DDD_DomainDriven.Repositories
{
    public class ParcelRepository : IParcelRepository
    {
        private readonly Context _context;

        public ParcelRepository(Context context)
        {
            _context = context;
        }

        public async Task<Parcel> GetParcelByTrackingNumberAsync(string trackingNumber)
        {
            return await _context.Parcels.Include(p => p.TrackingEvents)
                .FirstOrDefaultAsync(p => p.TrackingNumber == trackingNumber);
        }

        public async Task<IEnumerable<Parcel>> GetAllParcelsAsync()
        {
            return await _context.Parcels.Include(p => p.TrackingEvents).ToListAsync();
        }

        public async Task AddParcelAsync(Parcel parcel)
        {
            await _context.Parcels.AddAsync(parcel);
            await _context.SaveChangesAsync();
        }
    }
}
