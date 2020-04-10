using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team3.Models
{
    public class Profile
    {
        [Key]
        public int profileID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Most used email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter you most frequently used email address")]
        public string email { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your password!")]
        [StringLength(20)]
        
        public string password { get; set; }
        [StringLength(100)]
        [Required]
        public string Street { get; set; }

        [StringLength(50)]
        [Required]
        public string City { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be two characters")]
        [Required]
        public string State { get; set; }


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy", ApplyFormatInEditMode =true)]
        public Nullable<System.DateTime> dateofEmployment { get; set; }
    }
}