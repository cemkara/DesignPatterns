namespace Builder.Entities
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public GiftWrapOption GiftWrapOption { get; set; }

        public decimal TotalAmount
        {
            get
            {
                return Products.Sum(p => p.Price);
            }
        }
    }
}
