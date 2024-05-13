using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.Property(e => e.Address).HasMaxLength(255);
            builder.Property(e => e.CompanyName).HasMaxLength(255);
            builder.Property(e => e.Country).HasMaxLength(255);
            builder.Property(e => e.Description).HasMaxLength(512);
            builder.Property(e => e.Email).HasMaxLength(255);
            builder.Property(e => e.FirstName).HasMaxLength(255);
            builder.Property(e => e.Krs)
                .HasMaxLength(10)
                .HasColumnName("KRS");
            builder.Property(e => e.LastName).HasMaxLength(255);
            builder.Property(e => e.Nip)
                .HasMaxLength(10)
                .HasColumnName("NIP");
            builder.Property(e => e.PasswordHash).HasMaxLength(255);

            builder.HasOne(d => d.Photo).WithMany(p => p.Users)
                .HasForeignKey(d => d.PhotoId)
                .HasConstraintName("FK__User__PhotoId__7F2BE32F");

            builder.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__User__RoleId__7E37BEF6");
        }
    }
}
