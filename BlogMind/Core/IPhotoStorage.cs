using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface IPhotoStorage
    {
        Task<string> StorePhoto(string uploadsFolderPath, IFormFile file);
    }
}
