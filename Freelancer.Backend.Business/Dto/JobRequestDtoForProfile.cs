using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Business.Dto;

public class JobRequestDtoForProfile
{
    public int UserId { get; set; }
    public int JobId { get; set; }
    public JobRequestStatus Status { get; set; }
    public JobDtoForUserProfile? Job { get; set; }
}