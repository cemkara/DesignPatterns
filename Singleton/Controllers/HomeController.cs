using Microsoft.AspNetCore.Mvc;
using Singleton.Entities.Context;
using Singleton.Models;
using Singleton.SingletonPattern;
using System.Diagnostics;

namespace Singleton.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        private readonly Logger _logger;
        
        public HomeController(Context context, Logger logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            _logger.Log("Start App");

            var dbConnection = DatabaseConnection.Instance;
            dbConnection.Connect();

            var users = _context.Users.ToList();
            var products = _context.Products.ToList();
            var orders = _context.Orders.ToList();
            
            _logger.Log("End App");

            return View(new { Users = users, Products = products, Orders = orders });
        }
    }
}