using BlogMind.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface IAppUserRepository
    {
        Task<AppUser> GetUser(string id);

        Task<AppUser> GetUserWithAddress(string id);

        Task<List<AppUser>> GetUsersWithAddresses();

        void Remove(AppUser appUser);
    }
}

