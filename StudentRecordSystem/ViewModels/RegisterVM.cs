using System.ComponentModel.DataAnnotations;

namespace StudentRecordSystem.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string? ConfirmPassword { get; set; }
        
    }
}
