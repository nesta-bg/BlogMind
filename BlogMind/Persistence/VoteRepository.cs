using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public class VoteRepository : IVoteRepository
    {
        private readonly BlogDbContext context;

        public VoteRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task<Vote> GetVote(int postId, string userId)
        {
            return await context.Votes
                .SingleOrDefaultAsync(v => v.PostId == postId && v.AppUserId == userId);
        }

        public Int32 GetVoteCount(int postId, string userId)
        {
            return context.Votes
                .Where(v => v.PostId == postId && v.AppUserId != userId)
                .Sum(v => v.Mark);
        }

        public void Add(Vote vote)
        {
            context.Add(vote);
        }

        public void Remove(Vote vote)
        {
            context.Remove(vote);
        }
    }
}
