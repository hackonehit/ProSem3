using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Help_Desk.Models
{
    public class RequestReply
    {
        public Request Request { get; set; }
        public Reply Reply { get; set; }
    }
}