using HomeOwners.Models;
using HomeOwners.Models.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HomeOwners.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;

        public UserController(ILogger<HomeController> logger, UserManager<User> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        [Authorize(Policy = "UserOnly")]
        public async Task<IActionResult> Home()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            return View(currentUser);
        }

        [Authorize(Policy = "UserOnly")]
        public IActionResult Billing()
        {
            return View();
        }

        [Authorize(Policy = "UserOnly")]
        public IActionResult Community()
        {
            return View();
        }

        [Authorize(Policy = "UserOnly")]
        public IActionResult Forum()
        {
            return View();
        }

        [Authorize(Policy = "UserOnly")]
        public IActionResult Reservation()
        {
            return View();
        }

        [Authorize(Policy = "UserOnly")]
        public IActionResult Account()
        {
            return View();
        }
    }
}
