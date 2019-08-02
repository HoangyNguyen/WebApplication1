using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LastNameNotDavisAttribute : ValidationAttribute 
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value != null)
            {
                var returnValue = value.ToString();
                if (returnValue.ToLower() == "davis")
                {
                    return new ValidationResult("Davis is not allowed");
                }
                else
                    return ValidationResult.Success;
            }
            else
                return new ValidationResult("" + context);
        }
    }
    
}