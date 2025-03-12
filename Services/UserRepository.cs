using HomeOwners.Data;
using HomeOwners.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeOwnersManagementSystem.Services
{
    public class UserRepository
    {
        private readonly AppDBContext _context;

        public UserRepository(AppDBContext context)
        {

            _context = context;
        }

        public async Task<UserModel[]> GetUsers()
        {
            var users = await _context.User.ToArrayAsync<UserModel>();
            return users;
        }

        public UserModel? GetByEmailAndPassword(string email, string password)
        {
            var user = this._context.User.Where(u => u.Email == email & u.Password == password).FirstOrDefault();
            
            if (user == null)
            {
                return null;
            }

            return user;
        }
    }
}