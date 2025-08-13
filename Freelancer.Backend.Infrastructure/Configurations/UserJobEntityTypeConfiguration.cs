using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class UserJobEntityTypeConfiguration : IEntityTypeConfiguration<JobRequest>
    {
        public void Configure(EntityTypeBuilder<JobRequest> builder)
        {
            builder.HasKey(jr => new { jr.JobId, jr.UserId });

            builder.HasOne(d => d.Job)
                .WithMany(x => x.JobRequests)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserJobs__JobId__03F0984C");

            builder.HasOne(d => d.User)
                .WithMany(x => x.JobsUser)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserJobs__UserId__02FC7413");
        }
    }
}
