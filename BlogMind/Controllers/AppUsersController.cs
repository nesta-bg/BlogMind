using AutoMapper;
using BlogMind.Controllers.Resources;
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
        private readonly IMapper mapper;

        public AppUsersController(BlogDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AppUserResource>> GetUsers()
        {
            var appusers = await context.AppUsers
                .Include(u => u.Address)
                .ToListAsync();

            return mapper.Map<List<AppUser>, List<AppUserResource>>(appusers);
        }
    }
}
