using AutoMapper;
using BlogMind.Controllers.Resources;
using BlogMind.Models;
using BlogMind.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogMind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly BlogDbContext context;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly AuthSettings authSettings;

        public AppUsersController(
            BlogDbContext context, 
            IMapper mapper, 
            UserManager<AppUser> userManager,
            IOptions<AuthSettings> authSettings)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
            this.authSettings = authSettings.Value;
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

            try
            {
                var result = await this.userManager.CreateAsync(appuser, appuserResource.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginResource model)
        {
            var user = await this.userManager.FindByNameAsync(model.UserName);
            if (user != null && await this.userManager.CheckPasswordAsync(user, model.Password))
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.authSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
        }

        [HttpGet]
        [Route("LoggedInUser")]
        [Authorize]
        public async Task<Object> GetLoggedInUser()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var appuser = await this.userManager.FindByIdAsync(userId);

            return this.mapper.Map<AppUser, AppUserResource>(appuser);
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

            //return Ok(id);
            //Trying to Parse a String
            //SyntaxError: Unexpected token * in JSON at position *

            return Ok();
        }
    }
}
