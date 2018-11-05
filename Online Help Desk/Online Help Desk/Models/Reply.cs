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

        public string Image { get; set; }
        public string EUserName { get; set; }
        public string SUserName { get; set; }
        [Required]
        public string Remarks { get; set; }

    }
}