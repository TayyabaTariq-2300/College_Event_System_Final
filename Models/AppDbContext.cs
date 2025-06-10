using Microsoft.EntityFrameworkCore;

namespace College_Event_System_Final.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }

}
