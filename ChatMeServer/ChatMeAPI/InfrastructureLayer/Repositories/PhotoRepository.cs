using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;

namespace InfrastructureLayer.Repositories
{
    public class PhotoRepository : Repository<ConversationInfo>, IConversationInfoRepository
    {
        public PhotoRepository(MessengerContext db) : base(db)
        {

        }
    }
}