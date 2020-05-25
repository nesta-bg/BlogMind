using Microsoft.AspNetCore.Identity;

namespace BlogMind.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public string Website { get; set; }

        public Company Company { get; set; }
    }
}
