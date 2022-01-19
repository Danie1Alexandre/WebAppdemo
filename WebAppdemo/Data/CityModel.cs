using System.ComponentModel.DataAnnotations;

namespace WebAppdemo.Data
{
    public class CityModel
    {
        [Key]
        [MaxLength(4, ErrorMessage = "Need to Be Vaild Lenght of 4")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
