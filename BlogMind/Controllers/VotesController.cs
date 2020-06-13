using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class VotesController : Controller
    {
        private readonly BlogDbContext context;

        public VotesController(BlogDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{postId}/user/{userId}")]
        public async Task<IActionResult> GetUserVote(int postId, string userId)
        {
            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == postId);
            var user = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == userId);
            var vote = await context.Votes.SingleOrDefaultAsync(v => v.PostId == postId && v.AppUserId == userId);

            if (post == null || user == null) 
                return NotFound();
            else if (vote == null) 
                return Ok(0);
            else
                return Ok(vote.Mark);
        }

        [HttpGet("{postId}/{userId}")]
        public async Task<IActionResult> GetVoteCountExcludingUser(int postId, string userId)
        {
            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == postId);
            var user = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == userId);

            if (post == null || user == null)
                return NotFound();

            var count = context.Votes.Where(v => v.PostId == postId && v.AppUserId != userId).Sum(v => v.Mark);

            return Ok(count);
        }


        [HttpPost("{postId}/{userId}/{mark}")]
        public async Task<IActionResult> AddUserVote(int postId, string userId, int mark)
        {
            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == postId);
            var user = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == userId);

            if (post == null || user == null)
                return NotFound();

            var vote = await context.Votes.SingleOrDefaultAsync(v => v.PostId == postId && v.AppUserId == userId);

            if (vote != null)
            {
                return StatusCode(409, "This User has already voted this post.");
            }

            var newVote = new Vote
            {
                PostId = postId,
                AppUserId = userId,
                Mark = mark
            };

            context.Votes.Add(newVote);
            await context.SaveChangesAsync();

            return Ok(newVote.PostId);
        }

        [HttpDelete("{postId}/{userId}")]
        public async Task<IActionResult> DeleteUserVote(int postId, string userId)
        {
            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == postId);
            var user = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == userId);
            var vote = await context.Votes.SingleOrDefaultAsync(v => v.PostId == postId && v.AppUserId == userId);

            if (post == null || user == null || vote == null)
                return NotFound();

            context.Votes.Remove(vote);
            await context.SaveChangesAsync();

            return Ok(postId);
        }
    }
}
