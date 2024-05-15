namespace Freelancer.Backend.Domain;

public partial class UserPhoto
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public string? ContentType { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
