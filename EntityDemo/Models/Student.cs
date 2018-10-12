using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityDemo.Models
{
    public class Student
    {
        
        public int ID { get; set; }
        public string stud_name { get; set; }
        public string email { get; set; }

        public Course Course{ get; set; }

        public int CourseId { get; set; }
    }
}