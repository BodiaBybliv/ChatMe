using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Models.AuthModels
{
    public class SignInResponce
    {
        public string Access_Token { get; set; }

        public string Refresh_Token { get; set; }

        public DateTime ExpiresIn { get; set; }
    }
}
