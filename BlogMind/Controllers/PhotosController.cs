using BlogMind.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("/api/appusers/{appuserId}/photo")]
    public class PhotosController : Controller
    {
        private readonly BlogDbContext context;
        private readonly IHostingEnvironment host;

        public PhotosController(BlogDbContext context, IHostingEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(string appuserId, IFormFile file)
        {
            var appuser = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == appuserId);

            if (appuser == null)
                return NotFound();

            var uploadsFolderPath = Path.Combine(host.WebRootPath, "uploads");

            if (!Directory.Exists(uploadsFolderPath))
                Directory.CreateDirectory(uploadsFolderPath);

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(uploadsFolderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            appuser.Photo = fileName;
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
