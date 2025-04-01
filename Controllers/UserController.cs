using HomeOwners.Models;
using HomeOwners.Models.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HomeOwners.Controllers
{
    /**
     * Controller specifically for user accounts only.
     */
    [Authorize(Policy = "UserOnly")]
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;

        public UserController(ILogger<HomeController> logger, UserManager<User> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Home()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            return View(currentUser);
        }

        public IActionResult Reservation()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }

        public IActionResult Facility()
        {
            return View();
        }

        public IActionResult Event()
        {
            return View();
        }

        public IActionResult Announcement()
        {
            return View();
        }

        public IActionResult Forum()
        {
            return View();
        }

        public IActionResult Setting()
        {
            return View();
        }

        public IActionResult Billing()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
