using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookStore.Helpers
{
    public class MyCustomValidationAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) {
                string bookName = value.ToString();
                if (bookName.Contains("mvc")) {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("book Name does not contain mvc");
        }
    }
}
