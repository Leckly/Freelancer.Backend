using System.ComponentModel.DataAnnotations;

namespace Freelancer.Backend.Business.Dto
{
    public class RateDto
    {
        public int Id { get; set; }
        public byte Rate { get; set; }
        public string Comment { get; set; } = null!;
        public int? UserId { get; set; }
        public int? CreatingUserId { get; set; }
        public string? CreatingName { get; set; }
    }
}
