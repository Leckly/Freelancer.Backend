using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class ApplicationUserRoleEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
        {
            builder.HasData(new List<IdentityUserRole<int>>
            {
                new IdentityUserRole<int>()
                {
                    RoleId = 1,
                    UserId = 1,
                }
            });
        }
    }
}
