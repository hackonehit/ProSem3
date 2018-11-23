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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, StringLength(10), Required(ErrorMessage = "Username cannot be blank!"), Display(Name = "UserName")]
        public string SUsername { get; set; }
        [Required(ErrorMessage = "Password cannot be blank!"), Display(Name = "Password")]
        [StringLength(50)]
        [DataType(DataType.Password)]

        public string SPassword { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [Range(1,2)]
        public int Level { get; set; }
        [Required]
        public bool Status { get; set; }

    }
}