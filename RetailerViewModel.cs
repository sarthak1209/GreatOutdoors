using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace GreatOutdoors.Mvc.Models
{
    public class RetailerViewModel
    {
        public System.Guid RetailerID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Retailer Name can't be empty")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Retailer Name should contain alphabets only")]
        [Display(Name = "Name")]
        public string RetailerName { get; set; }
        [Required(ErrorMessage = "Retailer Mobile can't be empty")]
        [RegularExpression("^([9]{1})([234789]{1})([0-9]{8})$", ErrorMessage = "Retailer Mobile should contain number only")]
        [Display(Name = "Mobile")]
        public string RetailerMobile { get; set; }
        [Required(ErrorMessage = "Email can't be empty")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email should be in proper format")]
        // Add regex  AllowEmptyStrings = false,
        public string Email { get; set; }
        [Required(ErrorMessage = "Pasword can't be empty")]
        // [RegularExpression(@"(?=^.{6,}$)(?=.*\d)(?=.*[a-zA-Z])", ErrorMessage = "Password should contain atleast 6 digits and must include one upper case, one lower case and one number")]
        [Display(Name = "Password")]
        public string RetailerPassword { get; set; }
        public Nullable<decimal> RetailerDiscountPercentage { get; set; }
        public System.DateTime CreationDateTime { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public bool IsAdded { get; set; }
        public int Age { get; set; }
        [Required(ErrorMessage = "Select a gender")]
        public string Gender { get; set; }
    }
}