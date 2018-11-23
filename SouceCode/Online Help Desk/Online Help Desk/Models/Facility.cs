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
        [Required(ErrorMessage = "Facicity ID cannot be blank!")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string FacilityID { get; set; }
        [Required(ErrorMessage = "Facicity Name cannot be blank!")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="In 5 and 50 characters")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Facicity Type cannot be blank!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "In 5 and 50 characters")]
        public string FClass { get; set; }
        [Required(ErrorMessage = "Facicity Class cannot be blank!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "In 5 and 50 characters")]
        
        public string FType { get; set; }
        [Required(ErrorMessage = "Some Description Please")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "In 5 and 50 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Create date cannot be blank!"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd MMM yyy}")]
        public DateTime FDate { get; set; }
        [Required]

        public bool Status { get; set; }

    }
}