using AutoMapper;
using BlogMind.Controllers.Resources;
using BlogMind.Models;

namespace BlogMind.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser, AppUserResource>();
            CreateMap<Address, AddressResource>();

            CreateMap<AppUserResource, AppUser>();
            CreateMap<AddressResource, Address>();
        }
    }
}
