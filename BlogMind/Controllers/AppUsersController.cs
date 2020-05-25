using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    public class AppUsersController : Controller
    {
        private readonly BlogDbContext context;

        public AppUsersController(BlogDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetUsers()
        {
            return await context.AppUsers
                .Include(u => u.Address)
                .Include(u => u.Company)
                .ToListAsync();
        }
    }
}
