using Freelancer.Backend.Domain;

namespace Freelancer.Backend.Business.Dto
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? CompanyName { get; set; }

        public string? Krs { get; set; }

        public string? Nip { get; set; }

        public string? Address { get; set; }

        public string? Country { get; set; }

        public string? Description { get; set; }

        public string? Email { get; set; }

        public int? RoleId { get; set; }
        public virtual RoleDto Role { get; set; }

        public int? PhotoId { get; set; }

        public virtual PhotoDto? Photo { get; set; }

        public string[] Tags { get; set; }
    }
}
