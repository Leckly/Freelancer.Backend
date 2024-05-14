namespace Freelancer.Backend.Business.Dto
{
    public class UserTagDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; } = null!;
    }
}
