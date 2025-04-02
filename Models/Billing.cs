using HomeOwners.Models.Authentication;
using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models
{
    public class Billing
    {
        [Key]
        public required string Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required double Amount { get; set; }

        /**
         * The user who's required to pay the bill
         */
        [Required]
        public required User User { get; set; }

        [Required]
        public bool IsPaid { get; set; }
    }
}
