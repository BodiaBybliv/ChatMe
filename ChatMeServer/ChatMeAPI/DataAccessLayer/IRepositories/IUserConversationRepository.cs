using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public interface IUserConversationRepository : IRepository<UserConversation>
    {
        Task<List<UserConversation>> GetUsersByConversationAsync(int id);
    }
}
