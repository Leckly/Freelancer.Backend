using System;
using System.Collections.Generic;

namespace Freelancer.Backend.Domain;

public partial class JobPhoto
{
    public int? JobId { get; set; }

    public int? PhotoId { get; set; }

    public virtual Job? Job { get; set; }

    public virtual Photo? Photo { get; set; }
}
