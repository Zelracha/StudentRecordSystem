using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StudentRecordSystem.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(100)]
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
