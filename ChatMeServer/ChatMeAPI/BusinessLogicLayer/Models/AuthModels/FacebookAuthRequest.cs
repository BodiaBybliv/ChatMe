using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogicLayer.Models.AuthModels
{
    public class FacebookAuthRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string lastName { get; set; }

        public string photoUrl { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        public string accessToken { get; set; }
    }
}
