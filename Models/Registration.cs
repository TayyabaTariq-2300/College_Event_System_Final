namespace College_Event_System_Final.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }

        public int EventID { get; set; }
        public Event Event { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

}
