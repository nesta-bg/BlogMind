using BlogMind.Core.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface IPhotoService
    {
        Task UploadPhoto(AppUser user, IFormFile file, string uploadsFolderPath);
    }
}
