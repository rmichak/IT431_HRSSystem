using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRSSystem.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Employee Number")]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Use letters and numbers only please")]
        public string EmployeeNumber { get; set; }
    }
}