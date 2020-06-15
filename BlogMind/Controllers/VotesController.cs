using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class VotesController : Controller
    {
        private readonly BlogDbContext context;
        private readonly IAppUserRepository appUserRepository;
        private readonly IPostRepository postRepository;
        private readonly IVoteRepository voteRepository;

        public VotesController(
            BlogDbContext context,
            IAppUserRepository appUserRepository,
            IPostRepository postRepository,
            IVoteRepository voteRepository)
        {
            this.context = context;
            this.appUserRepository = appUserRepository;
            this.postRepository = postRepository;
            this.voteRepository = voteRepository;
        }

        [HttpGet("{postId}/user/{userId}")]
        public async Task<IActionResult> GetUserVote(int postId, string userId)
        {
            var post = await postRepository.GetPost(postId);
            var user = await appUserRepository.GetUser(userId);
            var vote = await voteRepository.GetVote(postId, userId);

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
            var post = await postRepository.GetPost(postId);
            var user = await appUserRepository.GetUser(userId);

            if (post == null || user == null)
                return NotFound();

            var count = voteRepository.GetVoteCount(postId, userId);

            return Ok(count);
        }


        [HttpPost("{postId}/{userId}/{mark}")]
        public async Task<IActionResult> AddUserVote(int postId, string userId, int mark)
        {
            var post = await postRepository.GetPost(postId);
            var user = await appUserRepository.GetUser(userId);

            if (post == null || user == null)
                return NotFound();

            var vote = await voteRepository.GetVote(postId, userId);

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
            var post = await postRepository.GetPost(postId);
            var user = await appUserRepository.GetUser(userId);
            var vote = await voteRepository.GetVote(postId, userId);

            if (post == null || user == null || vote == null)
                return NotFound();

            context.Votes.Remove(vote);
            await context.SaveChangesAsync();

            return Ok(postId);
        }
    }
}
