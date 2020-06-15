using BlogMind.Core;
using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogDbContext context;

        public CommentRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task<Comment> GetComment(int id)
        {
            return await context.Comments
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Comment>> GetCommentsByPost(int id)
        {
            return await context.Comments
                .Include(c => c.AppUser)
                .Include(c => c.Likes)
                .Where(c => c.PostId == id)
                .ToListAsync();
        }
    }
}
