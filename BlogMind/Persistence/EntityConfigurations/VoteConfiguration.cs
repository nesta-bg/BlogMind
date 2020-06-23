using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogMind.Persistence.EntityConfigurations
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder
                .HasKey(v => new { v.PostId, v.AppUserId });

            builder
                .HasOne(v => v.Post)
                .WithMany(p => p.Votes)
                .HasForeignKey(v => v.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(v => v.AppUser)
                .WithMany(u => u.Votes)
                .HasForeignKey(v => v.AppUserId);
        }
    }
}


