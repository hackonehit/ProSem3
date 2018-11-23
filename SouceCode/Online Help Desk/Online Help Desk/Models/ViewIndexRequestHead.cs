using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Help_Desk.Models
{
    public class ViewIndexRequestHead
    {
        public Facility Facility { get; set; }
        public Request Request { get; set; }
        public Staff Staff { get; set; }
    }
}