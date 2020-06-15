using BlogMind.Models;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public interface IFavoriteRepository
    {
        Task<Favorite> GetFavorite(int postId, string userId);

        void Add(Favorite favorite);

        void Remove(Favorite favorite);
    }
}

