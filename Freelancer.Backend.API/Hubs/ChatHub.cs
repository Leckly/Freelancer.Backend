using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain.Entities;
using System.Security.Claims;

namespace Freelancer.Backend.API.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly IChatService _chatService;

        public ChatHub(IChatService chatService)
        {
            _chatService = chatService;
        }

        public async Task JoinJobChat(string jobId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"job-{jobId}");
        }

        public async Task SendMessage(ChatMessageDto messageDto)
        {
            var userId = Context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId) || userId != messageDto.SenderId)
            {
                throw new HubException("Unauthorized");
            }

            var savedMessage = await _chatService.SaveMessageAsync(new ChatMessage
            {
                JobId = messageDto.JobId,
                SenderId = messageDto.SenderId,
                ReceiverId = messageDto.ReceiverId,
                Content = messageDto.Content,
                Timestamp = DateTime.Now,
                IsRead = false
            });

            await Clients.Group($"job-{messageDto.JobId}").SendAsync("ReceiveMessage", savedMessage);
        }

        public async Task MarkMessagesAsRead(string jobId, string senderId)
        {
            var userId = Context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                throw new HubException("Unauthorized");
            }

            await _chatService.MarkMessagesAsReadAsync(jobId, senderId, userId);
        }
    }

    public class ChatMessageDto
    {
        public string JobId { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string Content { get; set; }
    }
}
