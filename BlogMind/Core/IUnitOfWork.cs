using System.Threading.Tasks;

namespace BlogMind.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
