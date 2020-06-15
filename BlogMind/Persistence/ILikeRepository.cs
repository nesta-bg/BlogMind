﻿using BlogMind.Models;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public interface ILikeRepository
    {
        Task<Like> GetLike(int commentId, string userId);

        void Add(Like like);

        void Remove(Like like);
    }
}
