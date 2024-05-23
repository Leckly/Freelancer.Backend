namespace Freelancer.Backend.Domain;

public partial class Rating
{
    public int Id { get; set; }

    public byte Rate { get; set; }

    public string Comment { get; set; } = null!;

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
