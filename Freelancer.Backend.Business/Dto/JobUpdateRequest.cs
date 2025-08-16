using Freelancer.Backend.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Freelancer.Backend.Business.Dto;

public class JobUpdateRequest
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string[]? Tags { get; set; }

    public JobStatus JobStatus { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime StartDate { get; set; }

    public int Price { get; set; }

    public virtual ICollection<JobPhotoDto> JobPhotos { get; set; } = new List<JobPhotoDto>();
    
    public IFormFileCollection FormFiles { get; set; }
}
