using System.ComponentModel.DataAnnotations;
namespace College_Event_System_Final.Models
{
    public partial class Feedback
    {
        
        public int FeedbackID { get; set; }
        
        public int EventID { get; set; } // Must be public
        [Required]
        public Event Event { get; set; }
        
        public int UserID { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Comments { get; set; }
    }
}
