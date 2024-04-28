using Freelancer.Backend.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class ApplicationUserEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(x => x.CompanyName)
                .HasMaxLength(255);
            builder.Property(x => x.KRS)
                .HasMaxLength(10);
            builder.Property(x => x.NIP)
                .HasMaxLength(10);
            builder.Property(x => x.Address)
                .HasMaxLength(255);
            builder.Property(x => x.Country)
                .HasMaxLength(255);
            builder.Property(x => x.Tags)
                .HasMaxLength(512);
            builder.Property(x => x.Description)
                .HasMaxLength(512);

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(new ApplicationUser()
            {
                Id = 1,
                Email = "admin@gmail.com",
                PasswordHash = passwordHasher.HashPassword(default, "Password1!"),
                FirstName = "Jan",
                LastName = "Kowalski",
            });
        }
    }
}
