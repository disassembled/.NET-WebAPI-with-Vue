using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class GameCreateDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Platform { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}
