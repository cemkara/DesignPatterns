using Builder.Builders;
using Builder.Directors;
using Builder.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Builder.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDirector _orderDirector;

        public OrderController()
        {
            var orderBuilder = new OrderBuilder();
            _orderDirector = new OrderDirector(orderBuilder);
        }

        public IActionResult CreateOrder()
        {
            var product = new Product { Id = 1, Name = "Laptop", Price = 999.99m };
            var address = new ShippingAddress { AddressLine1 = "123 Main St", City = "New York", PostalCode = "10001" };
            var payment = new PaymentMethod { CardNumber = "1234567812345678", ExpiryDate = "12/25", CVV = "123" };

            var order = _orderDirector.CreateStandardOrder(product, address, payment);

            return View(order);
        }
    }
}
