using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Exceptions.MessageExceptions
{
    public class MessageInCorrectException : BaseException
    {
        public MessageInCorrectException(string message, int statusCode) : base(message, statusCode)
        {

        }
    }
}
