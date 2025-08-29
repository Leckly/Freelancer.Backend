using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.Property(e => e.Name).HasMaxLength(512);

            builder.HasData(new List<Role>()
            {
                new Role
                {
                    Id = 1,
                    Name = "Employee"
                },
                new Role
                {
                    Id = 2,
                    Name = "Employer"
                },
                new Role()
                {
                    Id = 3,
                    Name = "Admin"
                }
            });
        }
    }
}
