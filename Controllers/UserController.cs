﻿using HomeOwners.Data;
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
   
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;

        public UserController(
            ILogger<HomeController> logger, 
            UserManager<User> userManager, 
            ApplicationDbContext context)
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
                facilities = await _context.Facility.Where(e => e.Name.Contains(name)).ToArrayAsync();
                ViewBag.SearchTerm = name;
            }
            else
            {
                facilities = await _context.Facility.ToArrayAsync();
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

        public async Task<IActionResult> Billing()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var billings = await _context.Billing
                .Where(b => b.UserId == currentUser.Id)
                .ToListAsync();

            return View(billings);
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
