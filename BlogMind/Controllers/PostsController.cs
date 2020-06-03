using AutoMapper;
using BlogMind.Controllers.Resources;
using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
                .ToListAsync();

            return mapper.Map<List<Post>, List<PostResource>>(posts);
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<PostResource>> GetPostByUser(string id)
        {
            var posts = await context.Posts
                .Where(p => p.AppUserId == id)
                .ToListAsync();

            return mapper.Map<List<Post>, List<PostResource>>(posts);
        }
    }
}
