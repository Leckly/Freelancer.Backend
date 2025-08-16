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

    public int Price { get; set; }

    public string[]? Tags { get; set; }

    public virtual User? User { get; set; }
    public virtual ICollection<JobRequest> JobRequests { get; set; } = new List<JobRequest>();
    public virtual ICollection<JobPhoto> JobPhotos { get; set; } = new List<JobPhoto>();
}
