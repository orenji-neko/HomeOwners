using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models.Authentication
{
    public class UserRole : IdentityRole
    {
        [Required]
        [Display(Name = "Role")]
        public string? RoleName { get; set; }
    }
}
