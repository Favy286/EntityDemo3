using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityDemo.Models
{
    public class Faculty
    {

        public int ID { get; set; }

        public string facultyName { get; set; }

        public string email { get; set; }

        public Module Module { get; set; }

        public int ModuleId { get; set; }
    }
}