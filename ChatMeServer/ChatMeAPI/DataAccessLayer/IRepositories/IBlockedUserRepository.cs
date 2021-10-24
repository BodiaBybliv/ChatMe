using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public interface IBlockedUserRepository : IRepository<BlockedUser>
    {
        Task<BlockedUser> IsBlockedUserAsync(int userId, int blockedUserId);
    }
}
