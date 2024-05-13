using System;
using System.Collections.Generic;

namespace Freelancer.Backend.Domain;

public partial class Job
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual User? User { get; set; }
}
