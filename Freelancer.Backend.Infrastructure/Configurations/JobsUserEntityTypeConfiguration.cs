using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class JobsUserEntityTypeConfiguration : IEntityTypeConfiguration<JobsUser>
    {
        public void Configure(EntityTypeBuilder<JobsUser> builder)
        {
            builder.HasNoKey();

            builder.HasOne(d => d.Job).WithMany()
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobsUsers__JobId__05D8E0BE");

            builder.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobsUsers__UserI__04E4BC85");
        }
    }
}
