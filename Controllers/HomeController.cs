using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeOwners.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HomeOwners.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
    {
        _logger = logger;
        _userManager = userManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Authorize]
    public async Task<IActionResult> UHome()
    {
        var currentUser = await _userManager.GetUserAsync(User);
        ViewData["FirstName"] = currentUser?.FirstName;

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

    public IActionResult UAccount()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
