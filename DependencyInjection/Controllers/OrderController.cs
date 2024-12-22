using DependencyInjection.DAL.Entities;
using DependencyInjection.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductService _productService;
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public OrderController(IProductService productService, IPaymentService paymentService, IShippingService shippingService)
        {
            _productService = productService;
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(List<int> productIds)
        {
            var products = await _productService.GetAllProductsAsync();
            var order = new Order
            {
                Products = products.Where(p => productIds.Contains(p.Id)).ToList(),
                TotalAmount = products.Where(p => productIds.Contains(p.Id)).Sum(p => p.Price)
            };

            var payment = new Payment
            {
                CardNumber = "1234567890123456", 
                Amount = order.TotalAmount
            };
            var processedPayment = await _paymentService.ProcessPaymentAsync(payment);

            var shippingResult = await _shippingService.ShipOrderAsync(order);

            return View("OrderConfirmation", new { Order = order, PaymentStatus = processedPayment.PaymentStatus, ShippingInfo = shippingResult });
        }
    }
}
