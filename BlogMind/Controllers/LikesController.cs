using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class LikesController : Controller
    {
        private readonly BlogDbContext context;

        public LikesController(BlogDbContext context)
        {
            this.context = context;
        }

        [HttpPost("{commentId}/{userId}")]
        public async Task<IActionResult> AddLike(int commentId, string userId)
        {
            var comment = await context.Comments.SingleOrDefaultAsync(c => c.Id == commentId);
            var user = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == userId);

            if (comment == null || user == null)
                return NotFound();

            var like = await context.Likes.SingleOrDefaultAsync(l => l.CommentId == commentId && l.AppUserId == userId);

            if (like != null)
            {
                return StatusCode(409, "This User already likes this comment.");
            }

            var newLike = new Like
            {
                CommentId = commentId,
                AppUserId = userId
            };

            context.Likes.Add(newLike);
            await context.SaveChangesAsync();

            return Ok(comment.Id);
        }

        [HttpDelete("{commentId}/{userId}")]
        public async Task<IActionResult> DeleteLike(int commentId, string userId)
        {
            var comment = await context.Comments.SingleOrDefaultAsync(c => c.Id == commentId);
            var user = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == userId);
            var like = await context.Likes.SingleOrDefaultAsync(l => l.CommentId == commentId && l.AppUserId == userId);

            if (comment == null || user == null || like == null)
                return NotFound();

            context.Likes.Remove(like);
            await context.SaveChangesAsync();

            return Ok(comment.Id);
        }
    }
}
