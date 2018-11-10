using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Help_Desk.Models
{
    public class EndUser
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
        public string EUFullName { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [Required]
        public bool EUStatus { get; set; }
        [Required]
        [StringLength(20)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string DOB { get; set; }
    }
}