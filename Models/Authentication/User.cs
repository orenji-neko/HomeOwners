using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models.Authentication
{
    public class User : IdentityUser
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Middle Initial")]
        public string? MidInitial { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public ICollection<Billing> Billings { get; } = new List<Billing>();
    }
}
