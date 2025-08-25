using System.ComponentModel.DataAnnotations;

namespace Freelancer.Backend.Domain.Entities;

public class ChatMessage
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required]
    public string JobId { get; set; }

    [Required]
    public string SenderId { get; set; }

    [Required]
    public string ReceiverId { get; set; }

    [Required]
    public string Content { get; set; }

    public DateTime Timestamp { get; set; }

    public bool IsRead { get; set; }
}
