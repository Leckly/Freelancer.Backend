using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Business.Dto;

public class JobDtoForUserProfile
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string[]? Tags { get; set; }

    public JobStatus Status { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime StartDate { get; set; }

    public int Price { get; set; }
}
