using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;

namespace InfrastructureLayer.Repositories
{
    public class ConversationInfoRepository : Repository<ConversationInfo>, IConversationInfoRepository
    {
        public ConversationInfoRepository(MessengerContext context) : base(context)
        {
        }
    }
}