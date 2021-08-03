using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day22_UserRegistration
{
    class UserAnnotationFields
    {
        // validation of first name using annotation

        [Required(ErrorMessage = "first name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name should be minimum 3 characters")]
        [RegularExpression(@"^[A-Z][a-z]{3,}$", ErrorMessage = "First name is Invalid")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }
    }
}

