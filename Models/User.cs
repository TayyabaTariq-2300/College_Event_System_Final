using System.ComponentModel.DataAnnotations;

namespace College_Event_System_Final.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }  // "Student" or "Admin"
    }
}
