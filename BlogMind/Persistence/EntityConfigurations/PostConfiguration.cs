using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogMind.Persistence.EntityConfigurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                .Property(p => p.AppUserId)
                .IsRequired();

            builder
                .HasOne(p => p.AppUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
             