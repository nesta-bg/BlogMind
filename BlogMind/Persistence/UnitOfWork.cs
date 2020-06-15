using BlogMind.Core;
using System.Threading.Tasks;

namespace BlogMind.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogDbContext context;

        public UnitOfWork(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
