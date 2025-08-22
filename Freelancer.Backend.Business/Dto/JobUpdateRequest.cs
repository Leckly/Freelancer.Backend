namespace Freelancer.Backend.Business.Dto;

public class JobUpdateRequest
{

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string[]? Tags { get; set; }

    public DateTime StartDate { get; set; }

    public int Price { get; set; }
}
