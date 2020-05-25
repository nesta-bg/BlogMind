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

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
