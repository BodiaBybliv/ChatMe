using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories
{
    public class BlockedUserRepository : Repository<BlockedUser>, IBlockedUserRepository
    {
        public BlockedUserRepository(MessengerContext db) : base(db)
        {

        }

        public async Task<BlockedUser> IsBlockedUserAsync(int userId, int blockedUserId)
        {
            return await this.db.BlockedUsers
                .Where(blockedUser => blockedUser.UserId == userId && blockedUser.UserToBlockId == blockedUserId)
                .FirstOrDefaultAsync();
        }
    }
}