using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Exceptions.ConversationExceptions
{
    public class ConversationNotExistException : BaseException
    {
        public ConversationNotExistException(string message, int statusCode) : base(message, statusCode)
        {

        }
    }
}
