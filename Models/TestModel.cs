using ExpressiveAnnotations.Attributes;
using System.ComponentModel.DataAnnotations;

namespace WebFormMVC.Models
{
    public class TestModel
    {
        [Required(ErrorMessage = "First Name required"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required"), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email required"), Display(Name = "Email"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Married required"), Display(Name = "Married")]
        public bool Married { get; set; }

        [RequiredIf("Married == true", ErrorMessage = "Child Name required"), Display(Name = "Child Name")]
        public string ChildName { get; set; }

        [RequiredIf("Married == true", ErrorMessage = "Gender required"), Display(Name = "Gender")]
        public string Gender { get; set; }

        [RequiredIf("Married == true", ErrorMessage = "Age required and should be between 1 to 100"), Display(Name = "Age"), Range(1,100)]
        public int? Age { get; set; }

        [RequiredIf("Age >= 60", ErrorMessage = "Senior citizen"), Display(Name = "Seniro Citizen")]
        public string IsSeniorCitizen { get; set; }
    }
}