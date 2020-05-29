﻿namespace BlogMind.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
