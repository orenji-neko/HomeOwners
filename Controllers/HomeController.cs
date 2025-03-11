using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeOwners.Models;

namespace HomeOwners.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SignIn()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    public IActionResult UHome()
    {
        return View();
    }
    public IActionResult UBilling()
    {
        return View();
    }
    public IActionResult UCommunity()
    {
        return View();
    }
    public IActionResult UForum()
    {
        return View();
    }
    public IActionResult UReservation()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
