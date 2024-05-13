using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class JobTagEntityTypeConfiguration : IEntityTypeConfiguration<JobTag>
    {
        public void Configure(EntityTypeBuilder<JobTag> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(255);

            builder.HasOne(d => d.Job).WithMany(p => p.JobTags)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobTags__JobId__01142BA1");
        }
    }
}
