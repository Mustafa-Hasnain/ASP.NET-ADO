//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_signup
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This Field is Required")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(20)]
        public string Lastname { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$", ErrorMessage = "The conditions are string must be between 8 and 15 characters long. string must contain at least one number. string must contain at least one uppercase letter. string must contain at least one lowercase letter.")]
        public string Pass { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Pass")]
        public string Confirmpass { get; set; }
    }
}