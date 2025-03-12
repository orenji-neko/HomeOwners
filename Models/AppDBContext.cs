using HomeOwners.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeOwners.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<UserModel> User { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
    }
}