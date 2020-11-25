using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Core.DTOs
{
    public class AlumnoDataDto
    {
        public int age { get; set; }
        public String name { get; set; }
        public CourseDto math { get; set; }
        public CourseDto language { get; set; }
        public String id { get; set; }

    }
}
