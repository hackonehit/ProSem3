using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Help_Desk.Models
{
    public class Admin
    {
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), Required(ErrorMessage = "Username cannot be blank!")]
        [StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password cannot be blank!")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="between 3 and 50 character")]
        public string Password { get; set; }
        

        
        

    }
}