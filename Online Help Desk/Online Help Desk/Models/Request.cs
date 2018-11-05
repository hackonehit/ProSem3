using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Help_Desk.Models
{
    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public string RequestID { get; set; }
        
        
        public string FacilityID { get; set; }

        [Required]
        [Range(0,5)]
        public int Status { get; set; }

        public string ImageID { get; set; }
        public string Assignee { get; set; }
        public string Requestor { get; set; }

        [Required]
        
        public DateTime DateTime { get; set; }
        [Required]
        [StringLength(200)]
        public string Remarks{ get; set; }
    }
}