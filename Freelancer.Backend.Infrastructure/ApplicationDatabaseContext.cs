using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Freelancer.Backend.Infrastructure;

public partial class ApplicationDatabaseContext : DbContext
{
    public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobPhoto> JobPhotos { get; set; }

    public virtual DbSet<JobTag> JobTags { get; set; }

    public virtual DbSet<JobsUser> JobsUsers { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserJob> UserJobs { get; set; }

    public virtual DbSet<UserTag> UserTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserTagEntityTypeConfiguration).Assembly);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
