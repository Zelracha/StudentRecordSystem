using System.ComponentModel.DataAnnotations;

namespace StudentRecordSystem.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [DataType(DataType.Password)]
        public string ?Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
