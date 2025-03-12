using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models.Authentication
{
    public class SignUpModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public required string ConfirmPassword { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string MidInital { get; set; }
        [Required]
        public required string Address { get; set; }
        [Required]
        public required string Phone { get; set; }
    }
}
