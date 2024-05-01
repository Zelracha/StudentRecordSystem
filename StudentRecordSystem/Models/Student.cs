using System.ComponentModel.DataAnnotations;
namespace StudentRecordSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Enter your First Name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Enter your Last Name")]
        public string? LastName { get; set; }
        [Required (ErrorMessage = "Enter Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string DisplayDateOfBirth
        {
            get { return DateOfBirth.ToString("dd-MM-yyyy");}
        }
        [Required(ErrorMessage = "Enter your Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Enter your Phone Number")]
        public string? Phone { get; set; }
    }
}
