using HomeOwners.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeOwners.Controllers
{
    public class NavigationController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly UserManager<User> _userManager;

        public NavigationController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> UserNavbar()
        {
            var user = await _userManager.GetUserAsync(User);
            return PartialView("_UserNavbar", user);
        }
    }
}
