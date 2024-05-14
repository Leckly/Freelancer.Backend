namespace Freelancer.Backend.Domain;

public partial class JobTag
{
    public int Id { get; set; }

    public int JobId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Job Job { get; set; } = null!;
}
