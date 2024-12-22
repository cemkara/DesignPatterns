using Builder.Entities;

namespace Builder.Builders
{
    public interface IOrderBuilder
    {
        IOrderBuilder AddProduct(Product product);
        IOrderBuilder SetShippingAddress(ShippingAddress address);
        IOrderBuilder SetPaymentMethod(PaymentMethod payment);
        IOrderBuilder SetGiftWrapOption(GiftWrapOption giftWrap);
        Order Build();
    }
}
