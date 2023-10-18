using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ch11Lab.Models;

namespace Ch11Lab.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new UserTickets() { User = new User() });
    }

    [HttpPost]
    public IActionResult Index(UserTickets userTickets) 
    {
        ModelState.Clear();
        return View(userTickets);
    }
}
