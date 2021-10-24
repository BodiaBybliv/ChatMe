using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public enum Sex
    {
        Male,
        Female
    }
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string NickName { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public Sex Sex { get; set; }

        public string Photo { get; set; }

        public ICollection<Message> Messages { get; private set; }

        public ICollection<UserConversation> UserConversation { get; private set; }

        public ICollection<BlockedUser> BlockedUsers { get; private set; }

        public User()
        {
            Messages = new List<Message>();

            UserConversation = new List<UserConversation>();

            BlockedUsers = new List<BlockedUser>();
        }
    }
}
