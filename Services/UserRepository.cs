using HomeOwners.Data;
using HomeOwners.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeOwnersManagementSystem.Services
{
    public class UserRepository
    {
        private readonly IdentityContext _context;

        public UserRepository(IdentityContext context)
        {

            _context = context;
        }
    }
}