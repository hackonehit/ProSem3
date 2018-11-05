using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Online_Help_Desk.Models;

namespace Online_Help_Desk.Models
{
    public class DbModel : DbContext
    { 
        public DbModel() : base("OHDCon") { }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Staff> StaffList { get; set; }
        public DbSet<Facility> FacilityList { get; set; }
        public DbSet<EndUser> UserList { get; set; }
        public DbSet<Request> RequestList { get; set; }
        public DbSet<Reply> ReplyList { get; set; }
    }
}