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
        public string PhoneNumber { get; set; }


        public CityModel City { get; set; }
        public int CityId { get; set; }
        

       
       

     

    }
}
