using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAss01Proj.Data.Models
{
    internal class CourseInstructor
    {

        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        public int Evaluate { get; set; }
    }
}
