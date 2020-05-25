using BlogMind.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogMind.Persistence
{
    public class BlogDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {

        }
    }
}
