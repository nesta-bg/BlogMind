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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(string id)
        {
            var appuser = await context.AppUsers
                .Include(u => u.Address)
                .SingleOrDefaultAsync(u => u.Id == id);

            if (appuser == null)
                return NotFound();

            var appuserResource = mapper.Map<AppUser, AppUserResource>(appuser);

            return Ok(appuserResource);
        }

        [HttpGet]
        public async Task<IEnumerable<AppUserResource>> GetUsers()
        {
            var appusers = await context.AppUsers
                .Include(u => u.Address)
                .ToListAsync();

            return mapper.Map<List<AppUser>, List<AppUserResource>>(appusers);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] AppUserResource appuserResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var appuser = mapper.Map<AppUserResource, AppUser>(appuserResource);

            context.AppUsers.Add(appuser);
            await context.SaveChangesAsync();

            appuser = await context.AppUsers
                .Include(u => u.Address)
                .SingleOrDefaultAsync(u => u.Id == appuser.Id);

            var result = mapper.Map<AppUser, AppUserResource>(appuser);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] AppUserResource appuserResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var appuser = await context.AppUsers
                .Include(u => u.Address)
                .SingleOrDefaultAsync(u => u.Id == id);

            if (appuser == null)
                return NotFound();

            mapper.Map(appuserResource, appuser);
            await context.SaveChangesAsync();

            return Ok(mapper.Map<AppUser, AppUserResource>(appuser));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var appuser = await context.AppUsers.SingleOrDefaultAsync(u => u.Id == id);

            if (appuser == null)
                return NotFound();

            context.AppUsers.Remove(appuser);
            await context.SaveChangesAsync();

            return Ok(id);
        }
    }
}
