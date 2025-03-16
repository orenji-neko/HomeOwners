using HomeOwners.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HomeOwners.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<UserModel> _userManager;

        public UserController(ILogger<HomeController> logger, UserManager<UserModel> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Home()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewData["FirstName"] = currentUser?.FirstName;

            return View();
        }

        [Authorize]
        public IActionResult Billing()
        {
            return View();
        }

        [Authorize]
        public IActionResult Community()
        {
            return View();
        }

        [Authorize]
        public IActionResult Forum()
        {
            return View();
        }

        [Authorize]
        public IActionResult Reservation()
        {
            return View();
        }

        [Authorize]
        public IActionResult Account()
        {
            return View();
        }
    }
}
