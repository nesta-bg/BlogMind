using AutoMapper;
using BlogMind.Controllers.Resources;
using BlogMind.Core;
using BlogMind.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IPostRepository repository;

        public PostsController(IMapper mapper, IPostRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<PostResource>> GetPosts()
        {
            var posts = await repository.GetPosts();

            return mapper.Map<List<Post>, List<PostResource>>(posts);
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<PostResource>> GetPostsByUser(string id)
        {
            var posts = await repository.GetPostsByUser(id);

            return mapper.Map<List<Post>, List<PostResource>>(posts);
        }
    }
}
