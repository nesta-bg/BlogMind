using BlogMind.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public class LikeRepository : ILikeRepository
    {
        private readonly BlogDbContext context;

        public LikeRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task<Like> GetLike(int commentId, string userId)
        {
            return await context.Likes
                .SingleOrDefaultAsync(l => l.CommentId == commentId && l.AppUserId == userId);
        }
    }
}
