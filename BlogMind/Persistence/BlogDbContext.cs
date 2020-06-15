using BlogMind.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogMind.Persistence
{
    public class BlogDbContext : IdentityDbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Vote> Votes { get; set; }

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

            builder.Entity<Favorite>()
               .HasKey(f => new { f.PostId, f.AppUserId });

            builder.Entity<Favorite>()
                .HasOne(f => f.Post)
                .WithMany(p => p.Favorites)
                .HasForeignKey(f => f.PostId);

            builder.Entity<Favorite>()
                .HasOne(f => f.AppUser)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Like>()
              .HasKey(l => new { l.CommentId, l.AppUserId });

            builder.Entity<Like>()
                .HasOne(l => l.Comment)
                .WithMany(c => c.Likes)
                .HasForeignKey(l => l.CommentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Like>()
                .HasOne(l => l.AppUser)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.AppUserId);
            //.OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Vote>()
              .HasKey(v => new { v.PostId, v.AppUserId });

            builder.Entity<Vote>()
                .HasOne(v => v.Post)
                .WithMany(p => p.Votes)
                .HasForeignKey(v => v.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Vote>()
                .HasOne(v => v.AppUser)
                .WithMany(u => u.Votes)
                .HasForeignKey(v => v.AppUserId);
        }
    }
}
