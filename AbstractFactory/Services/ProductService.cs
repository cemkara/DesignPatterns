using AbstractFactory.AbstractFactoryPattern.Abstract;
using AbstractFactory.DAL.Context;
using AbstractFactory.DAL.Entities;

namespace AbstractFactory.Services
{
    public class ProductService
    {
        private readonly Context _context;

        public ProductService(Context context)
        {
            _context = context;
        }

        public void AddProduct(IProductFactory factory, string name, decimal price)
        {
            var product = factory.CreateProduct(name, price);
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
