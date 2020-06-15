using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class LikesController : Controller
    {
        private readonly BlogDbContext context;
        private readonly IAppUserRepository appUserRepository;
        private readonly ICommentRepository commentRepository;
        private readonly ILikeRepository likeRepository;

        public LikesController(
            BlogDbContext context,
            IAppUserRepository appUserRepository,
            ICommentRepository commentRepository,
            ILikeRepository likeRepository)
        {
            this.context = context;
            this.appUserRepository = appUserRepository;
            this.commentRepository = commentRepository;
            this.likeRepository = likeRepository;
        }

        [HttpPost("{commentId}/{userId}")]
        public async Task<IActionResult> AddLike(int commentId, string userId)
        {
            var comment = await commentRepository.GetComment(commentId);
            var user = await appUserRepository.GetUser(userId);

            if (comment == null || user == null)
                return NotFound();

            var like = await likeRepository.GetLike(commentId, userId);

            if (like != null)
            {
                return StatusCode(409, "This User already likes this comment.");
            }

            var newLike = new Like
            {
                CommentId = commentId,
                AppUserId = userId
            };

            likeRepository.Add(newLike);
            await context.SaveChangesAsync();

            return Ok(comment.Id);
        }

        [HttpDelete("{commentId}/{userId}")]
        public async Task<IActionResult> DeleteLike(int commentId, string userId)
        {
            var comment = await commentRepository.GetComment(commentId);
            var user = await appUserRepository.GetUser(userId);
            var like = await likeRepository.GetLike(commentId, userId);

            if (comment == null || user == null || like == null)
                return NotFound();

            likeRepository.Remove(like);
            await context.SaveChangesAsync();

            return Ok(comment.Id);
        }
    }
}
