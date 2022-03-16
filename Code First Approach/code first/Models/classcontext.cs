using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace code_first.Models
{
    public class classcontext : DbContext
    {
        public DbSet<Class1> Students { get; set; }
    }
}
