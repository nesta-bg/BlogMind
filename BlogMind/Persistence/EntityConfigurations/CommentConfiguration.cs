using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogMind.Persistence.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .ToTable("Comments");

            builder
                .Property(c => c.AppUserId)
                .IsRequired();

            builder
                .HasOne(c => c.AppUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}



             



