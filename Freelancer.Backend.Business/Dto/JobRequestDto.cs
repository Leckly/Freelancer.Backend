using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Business.Dto;

public class JobRequestDto
{
    public int UserId { get; set; }
    public int JobId { get; set; }
    public JobRequestStatus Status { get; set; }
}
