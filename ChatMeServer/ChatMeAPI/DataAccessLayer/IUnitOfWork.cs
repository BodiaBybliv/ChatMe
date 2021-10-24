using DataAccessLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IUnitOfWork
    {
        IConversationInfoRepository ConversationInfoRepository { get; }
        IMessageRepository MessageRepository { get; }
        IUserRepository UserRepository { get; }
        IConversationRepository ConversationRepository { get; }
        IBlockedUserRepository BlockedUserRepository { get; }
        IUserConversationRepository UserConversationRepository { get; }

        Task Commit();
    }
}
