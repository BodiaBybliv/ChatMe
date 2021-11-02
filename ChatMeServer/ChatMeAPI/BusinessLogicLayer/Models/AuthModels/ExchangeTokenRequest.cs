using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Models.AuthModels
{
    public class ExchangeTokenRequest
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
