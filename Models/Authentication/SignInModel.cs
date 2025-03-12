using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models.Authentication
{
    public class SignInModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
