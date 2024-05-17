using Freelancer.Backend.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Freelancer.Backend.Business.Dto
{
    public class RegisterDTO
    {
        public string Password {  get; set; }
        public string Email {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyName { get; set; }
        public string? KRS { get; set; }
        public string? NIP { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string[] Tags { get; set; }
        public string? Description { get; set; }
        public UserType UserType { get; set; }
        public IFormFile File { get; set; }
    }
}
