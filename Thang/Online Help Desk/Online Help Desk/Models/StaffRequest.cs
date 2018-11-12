using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Help_Desk.Models
{
    public class StaffRequest
    {
        public Staff SUserName { get; set; }
        public Request RequestID { get; set; }
    }
}