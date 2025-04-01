using HomeOwners.Data;
using HomeOwners.Models;
using HomeOwners.Models.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        private readonly IdentityContext _context;

        public UserController(
            ILogger<HomeController> logger, 
            UserManager<User> userManager, 
            IdentityContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
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

        /**
         * [GET] /User/Facility
         */
        [HttpGet]
        public async Task<IActionResult> Facility(string? name)
        {
            Facility[] facilities;

            if (name != null)
            {
                facilities = await _context.facility.Where(e => e.Name.Contains(name)).ToArrayAsync();
                ViewBag.SearchTerm = name;
            }
            else
            {
                facilities = await _context.facility.ToArrayAsync();
            }

            return View(facilities);
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
