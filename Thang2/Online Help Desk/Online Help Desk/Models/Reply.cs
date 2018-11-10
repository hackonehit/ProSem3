using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Help_Desk.Models
{
    public class Reply
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string ReplyID { get; set; }
        [Required]
        public string RequestID { get; set; }
        [Required]
        public string StaffID { get; set; }
        
        [Required]
        public string Content { get; set; }
        public string ReImage { get; set; }
        [Required]
        public DateTime ReplyDate { get; set; }

    }
}