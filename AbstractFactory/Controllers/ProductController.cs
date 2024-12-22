using AbstractFactory.AbstractFactoryPattern.Concrete;
using AbstractFactory.Services;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPhysicalProduct(string name, decimal price)
        {
            var factory = new PhysicalProductFactory();
            _productService.AddProduct(factory, name, price);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddDigitalProduct(string name, decimal price)
        {
            var factory = new DigitalProductFactory();
            _productService.AddProduct(factory, name, price);
            return RedirectToAction("Index");
        }
    }
}
