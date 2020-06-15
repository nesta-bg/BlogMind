using BlogMind.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogDbContext context;

        public PostRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task<Post> GetPost(int id)
        {
            return await context.Posts
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Post>> GetPosts()
        {
            return await context.Posts
                .ToListAsync();
        }

        public async Task<List<Post>> GetPostsByUser(string id)
        {
            return await context.Posts
                .Where(p => p.AppUserId == id)
                .ToListAsync();
        }
    }
}






