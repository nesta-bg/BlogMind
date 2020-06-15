using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class FavoritesController : Controller
    {
        private readonly BlogDbContext context;
        private readonly IAppUserRepository appUserRepository;
        private readonly IFavoriteRepository favoriteRepository;
        private readonly IPostRepository postRepository;

        public FavoritesController(
            BlogDbContext context, 
            IAppUserRepository appUserRepository, 
            IFavoriteRepository favoriteRepository,
            IPostRepository postRepository
            )
        {
            this.context = context;
            this.appUserRepository = appUserRepository;
            this.favoriteRepository = favoriteRepository;
            this.postRepository = postRepository;
        }

        [HttpGet("{postid}/{userId}")]
        public async Task<IActionResult> IsPostUserFavorite(int postId, string userId)
        {
            var post = await postRepository.GetPost(postId);
            var user = await appUserRepository.GetUser(userId);

            if (post == null || user == null)
                return NotFound();

            var favorite = await favoriteRepository.GetFavorite(postId, userId);

            if (favorite == null)
                return Ok(false);
            else
                return Ok(true);
        }

        [HttpPost("{postid}/{userId}")]
        public async Task<IActionResult> MakePostUserFavorite(int postId, string userId)
        {
            var post = await postRepository.GetPost(postId);
            var user = await appUserRepository.GetUser(userId);

            if (post == null || user == null)
                return NotFound();

            var favorite = await favoriteRepository.GetFavorite(postId, userId);

            if (favorite != null)
            {
                return StatusCode(409, "This post is User's favorite already.");
            }

            var newFavorite = new Favorite
            {
                PostId = postId,
                AppUserId = userId
            };

            context.Favorites.Add(newFavorite);
            await context.SaveChangesAsync();

            return Ok(postId);
        }

        [HttpDelete("{postid}/{userId}")]
        public async Task<IActionResult> RemovePostUserFavorite(int postId, string userId)
        {
            var post = await postRepository.GetPost(postId);
            var user = await appUserRepository.GetUser(userId);
            var favorite = await favoriteRepository.GetFavorite(postId, userId);

            if (post == null || user == null || favorite == null)
                return NotFound();

            context.Favorites.Remove(favorite);
            await context.SaveChangesAsync();

            return Ok(postId);
        }
    }
}
