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
        [Required(ErrorMessage ="Select please!")]
        public string Title { get; set; }
        [Required]
        [StringLength(200,MinimumLength =10,ErrorMessage ="More remarks more helpful")]
        
        public string Remarks{ get; set; }
        [Required]
        public string RequestStatus { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd MMM yyy}"),Display(Name ="Requested Date")]
        public DateTime RequestedDate { get; set; }
        public string RequestImage { get; set; }
        public string EUUsername { get; set; }
        [ForeignKey("EUUsername")]
        public  Enduser EndUser { get; set; }
        public string FacilityID { get; set; }
        [ForeignKey("FacilityID")]
        public Facility Facility { get; set; }
        public string SUsername { get; set; }
        [ForeignKey("SUsername")]
        public Staff Staff { get; set; }
        
    }
}