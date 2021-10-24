using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Exceptions.UserExceptions
{
    public class AccessTokenIsNotValidException : BaseException
    {
        public AccessTokenIsNotValidException(string message, int statusCode) : base(message, statusCode)
        {

        }
    }
}
