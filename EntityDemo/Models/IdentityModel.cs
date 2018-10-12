using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityDemo.Models
{
    public class IdentityModel : DbContext
    {
        public IdentityModel() : base("AptechEnuguDB")
        {
        }
            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }

            public DbSet<Faculty> Faculty { get; set; }

            public DbSet<Module> Module { get; set; }

    }
}