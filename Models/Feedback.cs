namespace College_Event_System_Final.Models
{
    public partial class Feedback
    {
        public int FeedbackID { get; set; }

        public int EventID { get; set; } // Must be public
        public Event Event { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int Rating { get; set; }
        public string Comments { get; set; }
    }
}
