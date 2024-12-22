namespace DependencyInjection.DAL.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
    }
}
