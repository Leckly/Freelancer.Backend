namespace Freelancer.Backend.Domain;

public partial class Photo
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public string? ContentType { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
