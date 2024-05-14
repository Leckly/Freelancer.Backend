namespace Freelancer.Backend.Business.Dto
{
    public class UpdateUserDto
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? CompanyName { get; set; }

        public string? Krs { get; set; }

        public string? Nip { get; set; }

        public string? Address { get; set; }

        public string? Country { get; set; }

        public string? Description { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }
}
