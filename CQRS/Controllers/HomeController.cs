using CQRS.CQRSPattern.Commands;
using CQRS.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    public class HomeController : Controller
    {
        private readonly GetProductQHandler getProductQHandler;
        private readonly CreateProductCHandler createProductCHandler;

        public HomeController(GetProductQHandler getProductQHandler, CreateProductCHandler createProductCHandler)
        {
            this.getProductQHandler = getProductQHandler;
            this.createProductCHandler = createProductCHandler;
        }

        public IActionResult Index()
        {
            var values = getProductQHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand createProduct)
        {
            createProductCHandler.Handle(createProduct);
            return RedirectToAction("Index");
        }
    }
}
