using Freelancer.Backend.Domain.Entities;

namespace Freelancer.Backend.Business.Interfaces;

public interface IChatService
{
    Task<IEnumerable<ChatMessage>> GetMessagesAsync(string jobId, string userId1, string userId2);
    Task<ChatMessage> SaveMessageAsync(ChatMessage message);
    Task MarkMessagesAsReadAsync(string jobId, string senderId, string receiverId);
}
