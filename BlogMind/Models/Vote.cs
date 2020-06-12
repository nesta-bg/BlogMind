namespace BlogMind.Models
{
    public class Vote
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int Mark { get; set; }
    }
}
