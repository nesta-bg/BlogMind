using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlogMind.Controllers.Resources
{
    public class CommentResource
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public AppUserResource AppUser { get; set; }

        public ICollection<LikeResource> Likes { get; set; }

        public CommentResource()
        {
            Likes = new Collection<LikeResource>();
        }
    }
}
