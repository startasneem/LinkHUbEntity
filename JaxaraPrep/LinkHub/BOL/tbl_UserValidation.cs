using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{

    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            LinkHubDbEntities aEntities=new LinkHubDbEntities();
            string values = value.ToString();
            int count = aEntities.tbl_User.Where(x => x.Email == values).ToList().Count();
            if (count!=0)
            {
                return new ValidationResult("Already EMail Exists");
            }
            return ValidationResult.Success;
        }
    }

    public class tbl_UserValidation
    {
        [Required]
        [EmailAddress]
        [UniqueEmail]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirmpassword { get; set; }
    }

    [MetadataType(typeof(tbl_UserValidation))]
    public partial class tbl_User
    {
        public string Confirmpassword { get; set; }
    }

}
