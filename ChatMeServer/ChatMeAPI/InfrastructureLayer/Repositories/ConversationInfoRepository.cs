using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;

namespace Infrastructure.Repositories
{
    public class ConversationInfoRepository : Repository<ConversationInfo>, IConversationInfoRepository
    {
        public ConversationInfoRepository(MessengerContext context) : base(context)
        {
        }
    }
}