using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Domain;

public partial class JobRequest
{
    public int UserId { get; set; }

    public int JobId { get; set; }

    public virtual Job Job { get; set; }

    public virtual User User { get; set; }

    public JobRequestStatus Status { get; set; } = JobRequestStatus.Pending;
}
