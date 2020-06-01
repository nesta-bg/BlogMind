namespace BlogMind.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
