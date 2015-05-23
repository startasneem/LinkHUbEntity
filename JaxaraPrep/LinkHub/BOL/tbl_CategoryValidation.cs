using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class UniqueCategoryAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            LinkHubDbEntities aEntities=new LinkHubDbEntities();
            string values = value.ToString();
            int count = aEntities.tbl_Category.Where(x => x.Name == values).ToList().Count();

            if (count!=0)
            {
                return new ValidationResult("Category Already exists"); 
            }
            return ValidationResult.Success;
        }
    }

    public class tbl_CategoryValidation
    {
        [Required]
        [UniqueCategory]
        public string Name { get; set; }
        [Required]
        public string Desc { get; set; }
    }

    [MetadataType(typeof(tbl_CategoryValidation))]
    public partial class tbl_Category
    {
         
    }
}
