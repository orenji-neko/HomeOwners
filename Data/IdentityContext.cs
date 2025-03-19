using HomeOwners.Models;
using HomeOwners.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeOwners.Data
{
    public class IdentityContext : IdentityDbContext<User, IdentityRole, string>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options) { }

        // You can add other DbSet properties here for your additional models
    }
}
