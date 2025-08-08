using System.ComponentModel.DataAnnotations;

namespace Freelancer.Backend.Business.Dto
{
    public class RateDto
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public byte Rate { get; set; }

        public string Comment { get; set; } = null!;

        public int? UserId { get; set; }
    }
}
