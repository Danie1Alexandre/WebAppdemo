using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppdemo.Data
{
    public class CountryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CityModel> Cyties { get; set; }
    }
}
