using AutoMapper;
using BlogMind.Controllers.Resources;
using BlogMind.Core;
using BlogMind.Core.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]/postId")]
    public class CommentsController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICommentRepository repository;

        public CommentsController(BlogDbContext context, IMapper mapper, ICommentRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<CommentResource>> GetComments(int id)
        {
            var comments = await repository.GetCommentsByPost(id);

            return mapper.Map<List<Comment>, List<CommentResource>>(comments);
        }
    }
}
