using BlogMind.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public interface IAppUserRepository
    {
        Task<AppUser> GetUser(string id);

        Task<AppUser> GetUserWithAddress(string id);

        Task<List<AppUser>> GetUsersWithAddresses();
    }
}

