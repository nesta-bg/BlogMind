﻿using BlogMind.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly BlogDbContext context;

        public AppUserRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task<AppUser> GetUser(string id)
        {
            return await context.AppUsers
                .SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<AppUser> GetUserWithAddress(string id)
        {
            return await context.AppUsers
                .Include(u => u.Address)
                .SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<AppUser>> GetUsersWithAddresses()
        {
            return await context.AppUsers
                .Include(u => u.Address)
                .ToListAsync();
        }
    }
}
