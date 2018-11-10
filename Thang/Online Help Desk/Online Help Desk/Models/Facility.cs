using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Help_Desk.Models
{
    public class Facility
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string FacilityID { get; set; }
        [Required]
        [StringLength(50)]
        public string FName { get; set; }
        [Required]
        [StringLength(50)]
        public string FClass { get; set; }
        [Required]
        [StringLength(50)]
        public string FType { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public DateTime FDate { get; set; }

    }
}