using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Domain;

public partial class Job
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime StartDate { get; set; }

    public JobStatus Status { get; set; }

    public string[] Tags { get; set; }

    public virtual User? User { get; set; }
    public virtual ICollection<User> JobUsers { get; set; } = new List<User>();
    public virtual ICollection<JobPhoto> JobPhotos { get; set; } = new List<JobPhoto>();
}
