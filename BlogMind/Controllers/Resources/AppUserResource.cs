using System.ComponentModel.DataAnnotations;

namespace BlogMind.Controllers.Resources
{
    public class AppUserResource
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public AddressResource Address { get; set; }

        public string Photo { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
