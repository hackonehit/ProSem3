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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ReplyID { get; set; }
        public int RequestID { get; set; }
        [ForeignKey("RequestID")]
        public Request Request { get; set; }

      
        [Required, Display(Name = "Staff replies")]
        public string SUsername { get; set; }
        [ForeignKey("SUsername")]
        public Staff Staff { get; set; }

        [Required(ErrorMessage = "Feedback's content cannot be blank!")]
        public string Content { get; set; }
        
        public string ReImage { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd MMM yyy}")]
        public DateTime FeedbackDate { get; set; }

    }
}