using BlogMind.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface IPostRepository
    {
        Task<Post> GetPost(int id);

        Task<List<Post>> GetPosts();

        Task<List<Post>> GetPostsByUser(string id);
    }
}

