namespace Freelancer.Backend.Domain;

public partial class Job
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
    public string[] Tags { get; set; }

    public virtual User? User { get; set; }
    public virtual ICollection<User> JobUsers { get; set; } = new List<User>();
    public virtual ICollection<Photo> JobPhotos { get; set; } = new List<Photo>();
}
