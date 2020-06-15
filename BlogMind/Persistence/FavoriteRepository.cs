using BlogMind.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public class FavoriteRepository : IFavoriteRepository
    {
        private readonly BlogDbContext context;

        public FavoriteRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task<Favorite> GetFavorite(int postId, string userId)
        {
            return await context.Favorites
                .SingleOrDefaultAsync(f => f.PostId == postId && f.AppUserId == userId);
        }
    }
}
