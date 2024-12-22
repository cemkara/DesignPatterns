using Builder.Entities;

namespace Builder.Builders
{
    public class OrderBuilder : IOrderBuilder
    {
        private Order _order;

        public OrderBuilder()
        {
            _order = new Order { Products = new List<Product>() };
        }

        public IOrderBuilder AddProduct(Product product)
        {
            _order.Products.Add(product);
            return this;
        }

        public IOrderBuilder SetShippingAddress(ShippingAddress address)
        {
            _order.ShippingAddress = address;
            return this;
        }

        public IOrderBuilder SetPaymentMethod(PaymentMethod payment)
        {
            _order.PaymentMethod = payment;
            return this;
        }

        public IOrderBuilder SetGiftWrapOption(GiftWrapOption giftWrap)
        {
            _order.GiftWrapOption = giftWrap;
            return this;
        }

        public Order Build()
        {
            return _order;
        }
    }
}
