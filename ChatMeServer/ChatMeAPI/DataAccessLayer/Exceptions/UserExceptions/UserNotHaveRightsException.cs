using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Exceptions.UserExceptions
{
    public class UserNotHaveRigthsException : BaseException
    {
        public UserNotHaveRigthsException(string message, int statusCode) : base(message, statusCode)
        {

        }
    }
}
