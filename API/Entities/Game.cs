using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Game
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