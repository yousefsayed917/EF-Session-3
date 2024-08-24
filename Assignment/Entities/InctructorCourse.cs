using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class InctructorCourse
    {
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public int Evaluate { get; set; }
        public Instructor Instructor { get; set; } 
        public Course Course { get; set; }
    }
}
