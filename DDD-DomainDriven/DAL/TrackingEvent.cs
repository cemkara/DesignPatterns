namespace DDD_DomainDriven.DAL
{
    public class TrackingEvent
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
        public int ParcelId { get; set; }
        public Parcel Parcel { get; set; }
    }
}
