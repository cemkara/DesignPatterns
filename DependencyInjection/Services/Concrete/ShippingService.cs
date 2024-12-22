using DependencyInjection.DAL.Entities;
using DependencyInjection.Services.Abstract;

namespace DependencyInjection.Services.Concrete
{
    public class ShippingService: IShippingService
    {
        public async Task<string> ShipOrderAsync(Order order)
        {
            await Task.Delay(500);
            return "Shipping initiated for order with total: " + order.TotalAmount;
        }
    }
}
