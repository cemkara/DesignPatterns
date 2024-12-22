using DependencyInjection.DAL.Context;
using DependencyInjection.DAL.Entities;
using DependencyInjection.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjection.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly Context _context;

        public ProductService(Context context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
