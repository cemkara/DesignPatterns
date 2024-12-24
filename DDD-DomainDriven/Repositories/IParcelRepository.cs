using DDD_DomainDriven.DAL;

namespace DDD_DomainDriven.Repositories
{
    public interface IParcelRepository
    {
        Task<Parcel> GetParcelByTrackingNumberAsync(string trackingNumber);
        Task<IEnumerable<Parcel>> GetAllParcelsAsync();
        Task AddParcelAsync(Parcel parcel);
    }
}
