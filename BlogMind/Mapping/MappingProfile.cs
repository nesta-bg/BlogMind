using AutoMapper;
using BlogMind.Controllers.Resources;
using BlogMind.Core.Models;

namespace BlogMind.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser, AppUserResource>();
            CreateMap<Address, AddressResource>();
            CreateMap<Post, PostResource>();
            CreateMap<Comment, CommentResource>();
            CreateMap<Like, LikeResource>();

            CreateMap<AppUserResource, AppUser>()
                .ForMember(u => u.Id, opt => opt.Ignore());
            CreateMap<AddressResource, Address>()
                .ForMember(a => a.Id, opt => opt.Ignore());
        }
    }
}
