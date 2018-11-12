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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int RequestID { get; set; }
        
        
        public string FacilityID { get; set; }
        [Required]
        public string EUUsername { get; set; }
        public string SUsername { get; set; }
        [Required]
        [Range(0,8)]
        public int RStatus { get; set; }
        [Required]
        
        public DateTime DateTime { get; set; }
        public string RImage { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        
        public string Remarks{ get; set; }
        public int MyProperty { get; set; }
    }
}