using DDD_DomainDriven.DAL;
using DDD_DomainDriven.Repositories;

namespace DDD_DomainDriven.Services
{
    public class TrackingService
    {
        private readonly IParcelRepository _parcelRepository;

        public TrackingService(IParcelRepository parcelRepository)
        {
            _parcelRepository = parcelRepository;
        }

        public async Task<Parcel> TrackParcelAsync(string trackingNumber)
        {
            var parcel = await _parcelRepository.GetParcelByTrackingNumberAsync(trackingNumber);
            return parcel;
        }

        public async Task AddTrackingEventAsync(string trackingNumber, string location, string status)
        {
            var parcel = await _parcelRepository.GetParcelByTrackingNumberAsync(trackingNumber);
            if (parcel != null)
            {
                var trackingEvent = new TrackingEvent
                {
                    Location = location,
                    Status = status,
                    Timestamp = DateTime.Now,
                    Parcel = parcel
                };

                parcel.TrackingEvents.Add(trackingEvent);
                await _parcelRepository.AddParcelAsync(parcel);
            }
        }
    }
}
