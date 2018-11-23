using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Help_Desk.Models
{
    public class Register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegisterID { get; set; }
        [Required(ErrorMessage = "Full name cannot be blank!")]
        [StringLength(50,MinimumLength =10,ErrorMessage ="Your name between 10 and 50 character")]
        public string FullName { get; set; }
       
        [Required(ErrorMessage = "Date of birth cannot be blank!"), Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Email cannot be blank!"), DataType(DataType.EmailAddress, ErrorMessage = "This is email format is not valid!")]
        [StringLength(50,MinimumLength =10)]
        
        public string Email { get; set; }
        [Required(ErrorMessage ="Can not be blank"),DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        [StringLength(11, MinimumLength = 10)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Can not be blank")]
        [Display(Name = "Address")]
        [StringLength(50, MinimumLength = 10)]
        public string Address { get; set; }
        [Required(ErrorMessage ="Must be selected")]
        [StringLength(10)]
        public string Gender { get; set; }
    }
}
