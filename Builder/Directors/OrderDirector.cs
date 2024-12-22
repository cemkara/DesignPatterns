using Builder.Builders;
using Builder.Entities;

namespace Builder.Directors
{
    public class OrderDirector
    {
        private readonly IOrderBuilder _builder;

        public OrderDirector(IOrderBuilder builder)
        {
            _builder = builder;
        }

        public Order CreateStandardOrder(Product product, ShippingAddress address, PaymentMethod payment)
        {
            return _builder.AddProduct(product)
                           .SetShippingAddress(address)
                           .SetPaymentMethod(payment)
                           .Build();
        }

        public Order CreateGiftOrder(Product product, ShippingAddress address, PaymentMethod payment, GiftWrapOption giftWrap)
        {
            return _builder.AddProduct(product)
                           .SetShippingAddress(address)
                           .SetPaymentMethod(payment)
                           .SetGiftWrapOption(giftWrap)
                           .Build();
        }
    }
}
