using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Online_Help_Desk.Models
{
    public class Enduser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string EUUserName { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string EUPassword { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        
        [StringLength(10)]
        public string Gender { get; set; }
        
        public bool Status { get; set; }
        
        [StringLength(20)]
        public string Phone { get; set; }
        
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name="Date of Birth")]
        [DataType(DataType.Date)]
        public string DOB { get; set; }
        
        public ICollection<Request> requests { get; set; }
    }
}