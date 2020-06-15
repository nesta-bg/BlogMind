using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
