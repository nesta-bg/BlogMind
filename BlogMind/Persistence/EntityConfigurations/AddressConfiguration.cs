using BlogMind.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogMind.Persistence.EntityConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .ToTable("Addresses");
            builder
                .HasOne(a => a.AppUser)
                .WithOne(u => u.Address)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}


