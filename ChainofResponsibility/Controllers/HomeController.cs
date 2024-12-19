using ChainofResponsibility.ChainofResponsibility;
using ChainofResponsibility.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChainofResponsibility.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel processViewModel)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee director = new Director();

            treasurer.SetNext(managerAsistant);
            managerAsistant.SetNext(manager);
            manager.SetNext(director);

            treasurer.HandleRequest(processViewModel);
            return View();
        }
    }
}