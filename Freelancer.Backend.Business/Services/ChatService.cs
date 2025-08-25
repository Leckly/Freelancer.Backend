using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain.Entities;
using Freelancer.Backend.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Freelancer.Backend.Business.Services;

public class ChatService : IChatService
{
    private readonly ApplicationDatabaseContext _context;

    public ChatService(ApplicationDatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ChatMessage>> GetMessagesAsync(string jobId, string userId1, string userId2)
    {
        return await _context.ChatMessages
            .Where(m => m.JobId == jobId)
            .Where(m =>
                (m.SenderId == userId1 && m.ReceiverId == userId2) ||
                (m.SenderId == userId2 && m.ReceiverId == userId1))
            .OrderBy(m => m.Timestamp)
            .ToListAsync();
    }

    public async Task<ChatMessage> SaveMessageAsync(ChatMessage message)
    {
        _context.ChatMessages.Add(message);
        await _context.SaveChangesAsync();
        return message;
    }

    public async Task MarkMessagesAsReadAsync(string jobId, string senderId, string receiverId)
    {
        var unreadMessages = await _context.ChatMessages
            .Where(m => m.JobId == jobId)
            .Where(m => m.SenderId == senderId && m.ReceiverId == receiverId)
            .Where(m => !m.IsRead)
            .ToListAsync();

        foreach (var message in unreadMessages)
        {
            message.IsRead = true;
        }

        await _context.SaveChangesAsync();
    }
}
