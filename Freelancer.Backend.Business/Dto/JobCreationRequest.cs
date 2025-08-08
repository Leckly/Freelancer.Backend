using Freelancer.Backend.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Freelancer.Backend.Business.Dto;

public class JobCreationRequest
{
    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string[]? Tags { get; set; }

    public JobStatus JobStatus { get; set; }

    public DateTime StartDate { get; set; }

    public IFormFileCollection? FormFiles { get; set; }
}
