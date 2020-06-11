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
    [Route("api/[controller]/postId")]
    public class CommentsController : Controller
    {
        private readonly BlogDbContext context;
        private readonly IMapper mapper;

        public CommentsController(BlogDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<CommentResource>> GetComments(int id)
        {
            var comments = await context.Comments
                .Include(c => c.AppUser)
                .Include(c => c.Likes)
                .Where(c => c.PostId == id)
                .ToListAsync();

            return mapper.Map<List<Comment>, List<CommentResource>>(comments);
        }
    }
}
