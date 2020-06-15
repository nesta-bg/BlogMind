namespace BlogMind.Core.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CatchPhrase { get; set; }

        public string Bs { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
