using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPWebAPI_CRUD.Models
{
    public class User
    {
        [Required(ErrorMessage = "Enter First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(dataType: DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(dataType: DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Passwords do not match!!!")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter Phone Number.")]
        [Phone]
        [Display(Name = "Phone#")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Select a City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please select a Gender")]
        public string Gender { get; set; }

        public bool isActive { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime UpdatedOn { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreatedOn { get; set; }

        public int Id { get; set; }

    }
}