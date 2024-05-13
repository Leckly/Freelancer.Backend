﻿using System;
using System.Collections.Generic;

namespace Freelancer.Backend.Domain;

public partial class UserTag
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
