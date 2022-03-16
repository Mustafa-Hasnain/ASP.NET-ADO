using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace code_first.Models
{
    public class Class1
    {   
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Class  { get; set; }
        [Required]
        public string School { get; set; }
    }
}