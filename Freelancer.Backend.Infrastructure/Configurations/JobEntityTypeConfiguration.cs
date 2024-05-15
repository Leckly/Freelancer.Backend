using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class JobEntityTypeConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Job");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).HasMaxLength(512);
            builder.Property(e => e.Name).HasMaxLength(255);

            builder.HasMany(x => x.JobUsers)
                .WithMany(x => x.JobsUser);

            builder.HasMany(x => x.JobPhotos)
                .WithOne(x => x.Job)
                .HasForeignKey(x => x.JobId);

            builder.HasOne(d => d.User).WithMany(p => p.Jobs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Job__UserId__02084FDA");
        }
    }
}
