using BlogMind.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface ICommentRepository
    {
        Task<Comment> GetComment(int id);
        Task<List<Comment>> GetCommentsByPost(int id);
    }
}

