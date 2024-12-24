namespace DDD_DomainDriven.DAL
{
    public class Parcel
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public List<TrackingEvent> TrackingEvents { get; set; } = new List<TrackingEvent>();
    }
}
