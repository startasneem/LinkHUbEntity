using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{

    public class UniqueUrlAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            LinkHubDbEntities aEntities=new LinkHubDbEntities();
            string urlvalue = value.ToString();
            int count = aEntities.tbl_Url.Where(x => x.url == urlvalue).ToList().Count();
            if (count!=0)
            
                return new ValidationResult("Url Already Exists");
            
            return ValidationResult.Success;
        }
    }

    public class tbl_UrlValidation
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [Url]
        [UniqueUrl]
        public string url { get; set; }
        [Required]
        public string urlDesc { get; set; }
        [Required]
        public int c_id { get; set; }
    }
    
    [MetadataType(typeof(tbl_UrlValidation))]
    public partial class tbl_Url
    {

    }



}
