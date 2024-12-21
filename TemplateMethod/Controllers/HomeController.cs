using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TemplateMethod.Models;

namespace TemplateMethod.Controllers;

public class HomeController : Controller
{
    public IActionResult BasicPlan()
    {
        Plans plan = new BasicPlan();
        plan.PlanType("Basic Plan");
        plan.PersonCount(1);
        plan.Price(50.00);
        plan.Resolution("1080p");
        plan.Content("Basic Plan Content");
        return View(plan);
    }

     public IActionResult StandardPlan()
    {
        Plans plan = new StandardPlan();
        plan.PlanType("Standart Plan");
        plan.PersonCount(2);
        plan.Price(100.00);
        plan.Resolution("1080p");
        plan.Content("Standart Plan Content");
        return View(plan);
    }
    public IActionResult UltraPlan()
    {
        Plans plan = new UltraPlan();
        plan.PlanType("Basic Plan");
        plan.PersonCount(3);
        plan.Price(200.00);
        plan.Resolution("1080p");
        plan.Content("Ultra Plan Content");
        return View(plan);
    }

}
