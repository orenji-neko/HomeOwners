using HomeOwners.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeOwners.Data
{
    public class IdentityContext : IdentityDbContext<UserModel>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options) { }

        // You can add other DbSet properties here for your additional models
    }
}
