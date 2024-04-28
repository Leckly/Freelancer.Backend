﻿using Microsoft.AspNetCore.Identity;

namespace Freelancer.Backend.Domain.Entities
{
    public class ApplicationUser : IdentityUser<int> 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string KRS { get; set; }
        public string NIP { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string[] Tags { get; set; }
        public string Description { get; set; }
    }
}
