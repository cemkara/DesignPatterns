using DependencyInjection.DAL.Entities;

namespace DependencyInjection.Services.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();

    }
}
