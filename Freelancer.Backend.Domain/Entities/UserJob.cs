using System;
using System.Collections.Generic;

namespace Freelancer.Backend.Domain;

public partial class UserJob
{
    public int UserId { get; set; }

    public int JobId { get; set; }

    public virtual Job Job { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
