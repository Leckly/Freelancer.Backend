using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Business.Dto;

public class JobRequestForJobDto
{
    public int UserId { get; set; }
    public int JobId { get; set; }
    public JobRequestStatus Status { get; set; }
    public UserDtoForJobRequest? User { get; set; }
}
