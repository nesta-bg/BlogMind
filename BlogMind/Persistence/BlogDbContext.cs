using BlogMind.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogMind.Persistence
{
    public class BlogDbContext : IdentityDbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Post> Posts { get; set; }

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

            builder.Entity<AppUser>()
               .Property(u => u.Name)
               .IsRequired()
               .HasMaxLength(155);

            builder.Entity<AppUser>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(155);

            builder.Entity<Post>()
                .Property(p => p.AppUserId)
                .IsRequired();

            builder.Entity<Post>()
              .HasOne(p => p.AppUser)
              .WithMany()
              .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Comment>()
                .ToTable("Comments");

            builder.Entity<Comment>()
              .Property(c => c.AppUserId)
              .IsRequired();

            builder.Entity<Comment>()
                .HasOne(c => c.AppUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
