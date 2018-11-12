using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Help_Desk.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SUserName { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string SPassword { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        
        public bool SStatus { get; set; }
        [Required]
        [Range(1,2)]
        public int Level { get; set; }
    }
}