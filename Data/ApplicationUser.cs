using Microsoft.AspNetCore.Identity;

namespace ETPrintshopWeb.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Fullname { get; set; }
        public string? ImagePath { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
    }

}
