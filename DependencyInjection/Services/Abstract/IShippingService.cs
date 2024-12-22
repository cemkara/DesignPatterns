using DependencyInjection.DAL.Entities;

namespace DependencyInjection.Services.Abstract
{
    public interface IShippingService
    {
        Task<string> ShipOrderAsync(Order order);

    }
}
