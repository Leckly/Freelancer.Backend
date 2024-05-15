using System;
using System.Collections.Generic;

namespace Freelancer.Backend.Domain;

public partial class JobPhoto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContentType { get; set; }
    public int JobId { get; set; }
    public virtual Job Job { get; set; }
}
