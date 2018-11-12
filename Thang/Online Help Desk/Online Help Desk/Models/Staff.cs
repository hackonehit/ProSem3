using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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
        [Range(1, 3)]
        public int Level { get; set; }
        [Required]
        public bool Status { get; set; }
        public ICollection<Request> Request { get; set; }
        public ICollection<Reply> Reply { get; set; }
    }
}