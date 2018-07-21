using System;
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models{
    public class User
    {
        [Required(ErrorMessage="Please Enter First Name")]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName {get;set;}
        [Required(ErrorMessage="Please Enter Last Name")]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName {get;set;}
        [Required(ErrorMessage="Please Enter Age")]
        [Display(Name="Age")]
        public int Age {get;set;}
        [Required(ErrorMessage="Please Enter Email")]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email {get;set;}
        [Required(ErrorMessage="Please Enter Password")]
        [DataType(DataType.Password)]
        [MinLength(6)]
        [Display(Name="Password")]
        public string Password {get;set;}
        [Required(ErrorMessage="Please Confirm Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        [Compare("Password", ErrorMessage="Error confirming Password")]
        public string ConfirmPassword {get;set;}
    }
}