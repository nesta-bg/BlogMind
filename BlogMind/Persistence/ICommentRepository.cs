using BlogMind.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetCommentsByPost(int id);
    }
}

