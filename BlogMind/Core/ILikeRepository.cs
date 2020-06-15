using BlogMind.Core.Models;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface ILikeRepository
    {
        Task<Like> GetLike(int commentId, string userId);

        void Add(Like like);

        void Remove(Like like);
    }
}

