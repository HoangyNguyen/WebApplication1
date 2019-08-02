using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class NotMay2019Attribute : ValidationAttribute
    {
        protected override ValidationResult IsValid (object value, ValidationContext context)
        {
            if (value != null)
            {
                var date = DateTime.Parse(value.ToString());
                if (date.Month == 5 && date.Year == 2019)
                {
                    return new ValidationResult("May 2019 is not allowed");
                }
                else
                    return ValidationResult.Success;
            }
            else
                return new ValidationResult("" + context);
        }
    }
}