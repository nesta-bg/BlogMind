using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class FavoritesController : Controller
    {
        private readonly BlogDbContext context;

        public FavoritesController(BlogDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{postid}/{userId}")]
        public async Task<IActionResult> IsPostUsersFavorite(int postId, string userId)
        {
            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == postId);
            var user = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == userId);

            if (post == null || user == null)
                return NotFound();

            var favorite = await context.Favorites.SingleOrDefaultAsync(f => f.PostId == postId && f.AppUserId == userId);

            if (favorite == null)
                return Ok(false);
            else
                return Ok(true);
        }
    }
}
