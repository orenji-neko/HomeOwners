using HomeOwners.Models;
using HomeOwners.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Net;

namespace HomeOwners.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        /**
         * Auto-generated Tables.
         */
        public DbSet<Facility> Facility {  get; set; }
        public DbSet<Billing> Billing { get; set; }
        public DbSet<Event> Events { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /**
             * Model to Model Connections
             */

            /**
             * User[One] <-> Billing[Many]
             */
            builder.Entity<User>()
                .HasMany(e => e.Billings)
                .WithOne(e => e.User)
                .HasForeignKey("UserId")
                .IsRequired();

            // password hashing bullshit
            var hasher = new PasswordHasher<User>();

            // Role seeding
            var adminRole = new IdentityRole
            {
                Id = "role-admin-0001",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };
            var userRole = new IdentityRole
            {
                Id = "role-user-0001",
                Name = "User",
                NormalizedName = "USER"
            };
            builder.Entity<IdentityRole>().HasData(adminRole);
            builder.Entity<IdentityRole>().HasData(userRole);

            // Creating user
            // User account
            var user = new User
            {
                Id = "test-user-0001",
                Email = "user@email.com",
                NormalizedEmail = "USER@EMAIL.COM",
                UserName = "user@email.com",
                NormalizedUserName = "USER@EMAIL.COM",
                LastName = "Doe",
                FirstName = "John",
                MidInitial = "A",
                Address = "123 User St."
            };
            user.PasswordHash = hasher.HashPassword(user, "password");
            builder.Entity<User>().HasData(user);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRole.Id,
                    UserId = user.Id,
                });

            // Facility seeding
            builder.Entity<Facility>().HasData([
                new Facility
                {
                    Id = "test-facility-0001",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know."
                },
                new Facility
                {
                    Id = "test-facility-0002",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know."
                },
                new Facility
                {
                    Id = "test-facility-0003",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know."
                },
                new Facility
                {
                    Id = "test-facility-0004",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know."
                },
                new Facility
                {
                    Id = "test-facility-0005",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know."
                },
                new Facility
                {
                    Id = "test-facility-0006",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know."
                },
                ]);
        }
    }


}