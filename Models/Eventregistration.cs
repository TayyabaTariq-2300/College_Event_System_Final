using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College_Event_System_Final.Models
{
    public class EventRegistration
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StudentName { get; set; } = string.Empty;

        [Required]
        public string StudentId { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Event")]
        public int EventId { get; set; }

        public Event? Event { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
