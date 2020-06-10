namespace BlogMind.Models
{
    public class Favorite
    {
        public int PostId { get; set; }

        public Post Post { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
