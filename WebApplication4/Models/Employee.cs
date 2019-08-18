using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models {
    public class Employee {
        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please enter valide Email address")]
        public string Email { get; set; }
        [Required]
        [Range(18,100)]
        public int Age { get; set; }
    }
}