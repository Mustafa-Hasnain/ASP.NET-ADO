//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    
    public partial class img
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string image_path { get; set; }

        public HttpPostedFileBase Img_file { get; set; }
    }
}