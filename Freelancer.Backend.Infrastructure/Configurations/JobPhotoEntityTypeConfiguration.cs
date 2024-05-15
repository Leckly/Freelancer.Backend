using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class JobPhotoEntityTypeConfiguration : IEntityTypeConfiguration<JobPhoto>
    {
        public void Configure(EntityTypeBuilder<JobPhoto> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .ToTable("JobPhoto");

            builder.HasOne(d => d.Job).WithMany(x => x.JobPhotos)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__JobPhoto__JobId__07C12930");
        }
    }
}
