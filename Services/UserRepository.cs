using HomeOwners.Data;
using HomeOwners.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeOwnersManagementSystem.Services
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {

            _context = context;
        }
    }
}