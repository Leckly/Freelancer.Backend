using Freelancer.Backend.Domain;
using Microsoft.AspNetCore.Http;

namespace Freelancer.Backend.Business.Dto
{
    public class JobDto
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
        public string[] Tags { get; set; }
        public virtual ICollection<User> JobUsers { get; set; } = new List<User>();
        public virtual ICollection<UserPhoto> JobPhotos { get; set; } = new List<UserPhoto>();
        public IFormFileCollection FormFiles { get; set; }
    }
}
