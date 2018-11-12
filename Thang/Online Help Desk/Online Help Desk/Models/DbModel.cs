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
        public DbSet<Enduser> UserList { get; set; }
        public DbSet<Request> RequestList { get; set; }
        public DbSet<Reply> ReplyList { get; set; }
        public DbSet<Register> RegisterList { get; set; }
     //   public DbSet<UserRequest> UserRequest { get; set; }
     //   public DbSet<StaffRequest> StaffRequests { get; set; }
   //     public DbSet<StaffReply> StaffReply { get; set; }
    //    public DbSet<RequestReply> RequestReply { get; set; }
    }
}