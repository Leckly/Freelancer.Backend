using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class JobPhotoEntityTypeConfiguration : IEntityTypeConfiguration<JobPhoto>
    {
        public void Configure(EntityTypeBuilder<JobPhoto> builder)
        {
            builder
                .HasNoKey()
                .ToTable("JobPhoto");

            builder.HasOne(d => d.Job).WithMany()
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__JobPhoto__JobId__07C12930");

            builder.HasOne(d => d.Photo).WithMany()
                .HasForeignKey(d => d.PhotoId)
                .HasConstraintName("FK__JobPhoto__PhotoI__08B54D69");
        }
    }
}
