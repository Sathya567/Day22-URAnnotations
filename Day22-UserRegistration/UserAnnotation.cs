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

        // validation of last name using annotation

        [Required(ErrorMessage = "lastname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name should be minimum 3 characters")]
        [RegularExpression(@"^[A-Z][a-z]{3,}$", ErrorMessage = "last name is Invalid")]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        // validation of email using annotation

        [Required(ErrorMessage = "email is required")]
        [RegularExpression(@"^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$", ErrorMessage = "Email id is invalid")]
        [DataType(DataType.EmailAddress)]
        public string emailId { get; set; }
    }
}

