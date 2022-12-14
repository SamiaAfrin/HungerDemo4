//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HungerDemo4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AdminLogin
    {

        [Key]
        public int adminid { get; set; }

        [Required(ErrorMessage = "Name cannot be empty")]
        [Display(Name = "User Name")]
        public string LoginName { get; set; }
        
        [StringLength(50)]
        [EmailAddress]
        [Required(ErrorMessage = "Email Required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [MinLength(8, ErrorMessage = "Password must be atleast 8 characters long")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
    }
}
