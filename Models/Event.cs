using System.ComponentModel.DataAnnotations;

namespace HomeOwners.Models
{
    public class Event
    {
        [Key]
        public required string Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required DateOnly StartedAt { get; set; }
    }
}
