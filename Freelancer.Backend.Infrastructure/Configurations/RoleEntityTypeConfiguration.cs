using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class RoleEntityTypeConfiguration : IEntityTypeConfiguration<IdentityRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
        {
            builder.HasData(new List<IdentityRole<int>>
            {
                new IdentityRole<int>
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole<int>
                {
                    Id = 2,
                    NormalizedName = "Employee".ToUpper(),
                    Name = "Employee"
                },
                new IdentityRole<int>
                {
                    Id = 3,
                    NormalizedName = "Employeer".ToUpper(),
                    Name = "Employeer"
                }
            });
        }
    }
}
