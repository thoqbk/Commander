using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { set; get; }

        [Required]
        [MaxLength(250)]
        public string HowTo { set; get; }

        [Required]
        public string Line { set; get; }

        [Required]
        public string Platform { set; get; }
    }
}
