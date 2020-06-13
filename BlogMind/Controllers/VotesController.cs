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
    }
}
