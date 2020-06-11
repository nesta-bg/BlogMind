using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlogMind.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public string Website { get; set; }

        public Company Company { get; set; }

        public string Photo { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Like> Likes { get; set; }

        public AppUser()
        {
            Favorites = new Collection<Favorite>();
            Likes = new Collection<Like>();
        }
    }
}
