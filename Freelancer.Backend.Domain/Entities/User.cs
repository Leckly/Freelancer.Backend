﻿namespace Freelancer.Backend.Domain;

public partial class User
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

    public string? PasswordHash { get; set; }

    public string? Email { get; set; }

    public int? RoleId { get; set; }

    public int? PhotoId { get; set; }

    public virtual ICollection<JobTag> JobTags { get; set; } = new List<JobTag>();

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    public virtual Photo? Photo { get; set; }

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();
}
