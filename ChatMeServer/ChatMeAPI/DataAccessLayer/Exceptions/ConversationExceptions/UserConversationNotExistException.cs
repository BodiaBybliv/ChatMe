using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Exceptions.ConversationExceptions
{
    public class UserConversationNotExistException : BaseException
    {
        public UserConversationNotExistException(string message, int statusCode) : base(message, statusCode)
        {

        }
    }
}
