using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppdemo.Data
{
    public class CityModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<PeopleModel> People { get; set; }


        public CountryModel Country { get; set; }
        public int CountryID { get; set; }
    }
}
