using System.ComponentModel.DataAnnotations;

namespace WebAppdemo.Data
{
    public class PeopleModel
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        public string Skills { get; set; }

    }
}
