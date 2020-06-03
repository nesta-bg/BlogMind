namespace BlogMind.Controllers.Resources
{
    public class CommentResource
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public AppUserResource AppUser { get; set; }
    }
}
