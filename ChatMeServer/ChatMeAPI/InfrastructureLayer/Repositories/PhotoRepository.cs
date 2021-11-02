using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;

namespace Infrastructure.Repositories
{
    public class PhotoRepository : Repository<ConversationInfo>, IConversationInfoRepository
    {
        public PhotoRepository(MessengerContext db) : base(db)
        {

        }
    }
}