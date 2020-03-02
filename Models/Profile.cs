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
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Most used email")]
        public string email { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Phone Number")]
        public string phone { get; set; }
        [Display(Name = "Hire Date")]
        public DateTime dateofEmployment { get; set; }
    }
}