using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogMind.Persistence.EntityConfigurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(155);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(155);
        }
    }
}
                