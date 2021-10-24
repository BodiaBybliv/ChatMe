using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public enum ConversationType
    {
        Chat,
        Group,
        Channel
    }
    public class Conversation
    {
        public int Id { get; set; }

        public int? LastMessageId { get; set; }
        public Message LastMessage { get; set; }

        public ICollection<Message> Messages { get; private set; }

        public List<UserConversation> UserConversations { get; set; }

        public ConversationType Type { get; set; }
        public ConversationInfo ConversationInfo { get; set; }

        public Conversation()
        {
            this.Messages = new List<Message>();

            this.UserConversations = new List<UserConversation>();
        }
    }
}
