using BlogMind.Core;
using BlogMind.Core.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("/api/appusers/{appuserId}/photo")]
    public class PhotosController : Controller
    {
        private readonly IHostingEnvironment host;
        private readonly PhotoSettings photoSettings;
        private readonly IPhotoService photoService;
        private readonly IAppUserRepository appUserRepository;
        private readonly IUnitOfWork unitOfWork;


        public PhotosController(
            IHostingEnvironment host,
            IOptionsSnapshot<PhotoSettings> options,
            IPhotoService photoService,
            IAppUserRepository appUserRepository,
            IUnitOfWork unitOfWork)
        {
            this.host = host;
            this.photoSettings = options.Value;
            this.photoService = photoService;
            this.appUserRepository = appUserRepository;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(string appuserId, IFormFile file)
        {
            var appuser = await appUserRepository.GetUser(appuserId);

            if (appuser == null)
                return NotFound();

            if (file == null) return BadRequest("Null file");
            if (file.Length == 0) return BadRequest("Empty file");
            if (file.Length > photoSettings.MaxBytes) return BadRequest("Max file size exceeded");
            if (!photoSettings.IsSupported(file.FileName)) return BadRequest("Invalid file type.");

            var uploadsFolderPath = Path.Combine(host.WebRootPath, "uploads");
            await photoService.UploadPhoto(appuser, file, uploadsFolderPath);
            
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Delete(string appuserId)
        {
            var appuser = await appUserRepository.GetUser(appuserId);

            if (appuser == null)
                return NotFound();

            var fileName = appuser.Photo;
            var uploadsFolderPath = Path.Combine(host.WebRootPath, "uploads");

            var filePath = Path.Combine(uploadsFolderPath, fileName);

            var fileInfo = new FileInfo(filePath);

            if (fileInfo != null)
            {
                System.IO.File.Delete(filePath);
                fileInfo.Delete();
            }

            appuser.Photo = null;
            await unitOfWork.CompleteAsync();

            return Ok();
        }
    }
}
