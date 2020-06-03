using AutoMapper;
using BlogMind.Controllers.Resources;
using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly BlogDbContext context;
        private readonly IMapper mapper;

        public PostsController(BlogDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PostResource>> GetPosts()
        {
            var posts = await context.Posts
                .Include(p => p.Comments)
                .ThenInclude(c => c.AppUser)
                .ToListAsync();

            return mapper.Map<List<Post>, List<PostResource>>(posts);
        }
    }
}
