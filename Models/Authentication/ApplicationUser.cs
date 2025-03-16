using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Middle Initial")]
        public string MidInitial { get; set; }

        [Required]
        public string Address { get; set; }

        // Note: IdentityUser already has PhoneNumber, so you can remove a duplicate Phone property.
    }
}
