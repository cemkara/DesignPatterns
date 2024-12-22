using Factory.DAL.Context;
using Factory.FactoryPattern;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;
        private readonly ProductFactory _productFactory;

        public ProductController(Context context, ProductFactory productFactory)
        {
            _context = context;
            _productFactory = productFactory;
        }

        public IActionResult CreateProduct(string productType)
        {
            var product = _productFactory.CreateProduct(productType);

            _context.Products.Add(product);
            _context.SaveChanges();

            return View("ProductCreated", product); 
        }

        public IActionResult ListProducts()
        {
            var products = _context.Products.ToList();
            return View("ProductList", products);
        }
    }
}
