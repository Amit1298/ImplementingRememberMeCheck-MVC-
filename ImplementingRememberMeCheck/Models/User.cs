//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImplementingRememberMeCheck.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int Id { get; set; }
        [DisplayName("Username")]
        [Required(ErrorMessage ="Username is Required")]
        public string username { get; set; }
        [DisplayName("password")]
        [Required(ErrorMessage ="Password is Required")]
        public string password { get; set; }
        [DisplayName("Checkbox")]
        public bool RememberMe { get; set; }
    }
}
