using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models
{
    public class Facility
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
