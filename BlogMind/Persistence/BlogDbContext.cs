using BlogMind.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogMind.Persistence
{
    public class BlogDbContext : IdentityDbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Address>()
               .ToTable("Addresses");

            builder.Entity<Address>()
               .HasOne(a => a.AppUser)
               .WithOne(u => u.Address)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Company>()
               .ToTable("Companies");

            builder.Entity<Company>()
              .HasOne(c => c.AppUser)
              .WithOne(u => u.Company)
              .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Geo>()
                .ToTable("Geos");
        }
    }
}
