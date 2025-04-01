using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models
{
    public class Facility
    {
        [Key]
        public required string Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Address { get; set; }

        [Required]
        public required string Description { get; set; }
    }
}
