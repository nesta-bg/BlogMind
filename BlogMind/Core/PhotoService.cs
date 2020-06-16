using BlogMind.Core.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoStorage photoStorage;
        private readonly IUnitOfWork unitOfWork;
        public PhotoService(IUnitOfWork unitOfWork, IPhotoStorage photoStorage)
        {
            this.unitOfWork = unitOfWork;
            this.photoStorage = photoStorage;
        }

        public async Task UploadPhoto(AppUser user, IFormFile file, string uploadsFolderPath)
        {
            var fileName = await photoStorage.StorePhoto(uploadsFolderPath, file);

            user.Photo = fileName;
            await unitOfWork.CompleteAsync();
        }

    }
}


