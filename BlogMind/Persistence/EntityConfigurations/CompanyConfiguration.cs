using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogMind.Persistence.EntityConfigurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder
                .ToTable("Companies");
            builder
                .HasOne(c => c.AppUser)
                .WithOne(u => u.Company)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}


