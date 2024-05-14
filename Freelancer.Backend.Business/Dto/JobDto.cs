using Freelancer.Backend.Domain;

namespace Freelancer.Backend.Business.Dto
{
    public class JobDto
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
        public virtual ICollection<User> JobUsers { get; set; } = new List<User>();
        public virtual ICollection<Photo> JobPhotos { get; set; } = new List<Photo>();

        public virtual ICollection<JobTag> JobTags { get; set; } = new List<JobTag>();
    }
}
