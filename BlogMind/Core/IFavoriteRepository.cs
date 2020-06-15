using BlogMind.Core.Models;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface IFavoriteRepository
    {
        Task<Favorite> GetFavorite(int postId, string userId);

        void Add(Favorite favorite);

        void Remove(Favorite favorite);
    }
}

