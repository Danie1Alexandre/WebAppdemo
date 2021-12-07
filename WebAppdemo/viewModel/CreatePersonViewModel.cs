using System.ComponentModel.DataAnnotations;
namespace WebAppdemo.viewModel
{
    public class CreatePersonViewModel 
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter name."), MaxLength(45), MinLength(3)]
        [Display(Name = "Name")]
        public string personName { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter city."), MaxLength(45), MinLength(3)]
        [Display(Name = "city")]
        public string personCity { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter phone nummber."), MaxLength(45), MinLength(3)]
        [Display(Name = "phone nummber")]
        public string personPhoneNumber { get; set; }
    }
}
