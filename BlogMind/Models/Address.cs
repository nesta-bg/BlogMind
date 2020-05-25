namespace BlogMind.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string Suite { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public Geo Geo { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
