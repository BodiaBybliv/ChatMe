using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public interface IConversationRepository : IRepository<Conversation>
    {
        Task<bool> ChatExistAsync(int firstUserId, int secondUserId);

        Task<List<Conversation>> GetUserChatsAsync(int userid);

        Task<Conversation> GetChatContentAsync(int id);

        Task<Conversation> GetWithUsersConversationsAsync(int id);

        Task<List<Conversation>> SearchConversationsAsync(string filter, int userId);

        Task<bool> isUserConversationMember(int conversationId, int userId);
    }
}
