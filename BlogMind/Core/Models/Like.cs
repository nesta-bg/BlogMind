namespace BlogMind.Core.Models
{
    public class Like
    {
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
