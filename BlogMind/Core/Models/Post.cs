using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlogMind.Core.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Vote> Votes { get; set; }

        public Post()
        {
            Comments = new Collection<Comment>();
            Favorites = new Collection<Favorite>();
            Votes = new Collection<Vote>();
        }
    }
}
