namespace Freelancer.Backend.Business.Dto;

public class RateCreationRequest
{
    public byte Rate { get; set; }
    public string Comment { get; set; } = null!;
    public int? UserId { get; set; }
    public int? CreatingUserId { get; set; }
}
