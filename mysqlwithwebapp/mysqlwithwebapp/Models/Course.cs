using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mysqlwithwebapp.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public decimal rating { get; set; }
    }
}
