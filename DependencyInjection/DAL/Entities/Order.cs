namespace DependencyInjection.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
