using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Exceptions.MessageExceptions
{
    public class MessageNotExistException : BaseException
    {
        public MessageNotExistException(string message, int statusCode) : base(message, statusCode)
        {

        }
    }
}
