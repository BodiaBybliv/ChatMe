using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Models.AuthModels
{
    public class ValidationResponce
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public bool is_valid { get; set; }
    }
}
