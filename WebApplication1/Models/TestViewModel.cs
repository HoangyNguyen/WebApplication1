using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TestViewModel
    {
        [Display (Name ="First ")]
        public string Given { get; set; }
        [Display(Name = "Middle ")]
        public string Middle { get; set; }
        [Display(Name = "Last ")]
        [LastNameNotDavis]
        public string Family { get; set; }
        [Display(Name = "Date of Birth ")]
        [DataType(DataType.Date)]
        [NotMay2019]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Phone ")]
        public string Phone { get; set; }
        [Display(Name = "Address ")]
        public string Address { get; set; }
        [Display(Name = "Additional Address ")]
        public string Address1 { get; set; }
        [Display(Name = "City ")]
        public string City { get; set; }
        [Display(Name = "State ")]
        public string State { get; set; }
        [Display(Name = "Postal Code ")]
        public string PostalCode { get; set; }
    }
}