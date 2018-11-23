using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Help_Desk.Models
{
    public class Enduser
    {
        
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, StringLength(10), Required(ErrorMessage ="Cannot be blank"), Display(Name = "User Name")]

        public string EUUsername { get; set; }
        [Required(ErrorMessage = "Cannot be blank"), DataType(DataType.Password), Display(Name = "Password")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Between 3 and 50 characters")]
        public string EUPassword { get; set; }
        
        
        [Required, Display(Name = "Full Name")]
        [StringLength(50,MinimumLength =10, ErrorMessage ="Between 10 and 50 characters")]
        public string EUFullName { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required]
        public bool EUStatus { get; set; }
        [Required,DataType(DataType.PhoneNumber)]
        [StringLength(11,MinimumLength =10)]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Address")]
        public string Address { get; set; }
       
        [Required, DataType(DataType.EmailAddress, ErrorMessage = "This email format is invalid!"), Display(Name = "Email")]
        [StringLength(50,MinimumLength =10,ErrorMessage ="Must be between 10 and 50 characters")]
        public string Email { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd MMM yyy}"), Display(Name = "Date Of Birth")]
        public string DOB { get; set; }
        
    }
}