using BlogMind.Models;
using System;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public interface IVoteRepository
    {
        Task<Vote> GetVote(int postId, string userId);

        Int32 GetVoteCount(int postId, string userId);
    }
}

