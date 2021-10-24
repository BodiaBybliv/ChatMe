using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Exceptions.ConversationExceptions
{
    public class ConversationAlreadyExistException : BaseException
    {
        public ConversationAlreadyExistException(string message, int statusCode) : base(message, statusCode)
        {

        }
    }
}
