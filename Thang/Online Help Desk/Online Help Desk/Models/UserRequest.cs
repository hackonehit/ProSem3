using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Help_Desk.Models
{
    public class UserRequest
    {
        public Enduser Enduser { get; set; }
        public Request Request { get; set; }
    }
}