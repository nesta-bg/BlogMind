﻿namespace BlogMind.Controllers.Resources
{
    public class AppUserResource
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public AddressResource Address { get; set; }
    }
}