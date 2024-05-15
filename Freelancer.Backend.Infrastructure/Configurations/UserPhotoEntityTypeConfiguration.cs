using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class UserPhotoEntityTypeConfiguration : IEntityTypeConfiguration<UserPhoto>
    {
        public void Configure(EntityTypeBuilder<UserPhoto> builder)
        {
            builder.ToTable("UserPhoto");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Name).HasMaxLength(255);

            builder.HasOne(x => x.User)
                .WithOne(x => x.Photo)
                .HasForeignKey<UserPhoto>(x => x.UserId);
        }
    }
}
