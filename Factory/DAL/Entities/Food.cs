namespace Factory.DAL.Entities
{
    public class Food : Product
    {
        public DateTime ExpirationDate { get; set; }
        public string Manufacturer { get; set; }
    }
}
