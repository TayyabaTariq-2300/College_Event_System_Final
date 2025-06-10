using Microsoft.AspNetCore.Identity;
namespace College_Event_System_Final.Helpers
{
    using College_Event_System_Final.Models;
    using Microsoft.AspNetCore.Identity;

    public static class PasswordHelper
    {
        private static PasswordHasher<User> hasher = new PasswordHasher<User>();

        public static string HashPassword(User user, string password)
        {
            return hasher.HashPassword(user, password);
        }

        public static bool VerifyPassword(User user, string hashedPassword, string password)
        {
            var result = hasher.VerifyHashedPassword(user, hashedPassword, password);
            return result == PasswordVerificationResult.Success;
        }
    }

}
