using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment.Entities
{
    public class Department
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }
        public string Name { get; set; }=string.Empty;
        public TimeOnly HiringDate { get; set; }
        #region Student
        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        #endregion
        #region Instructor
        [InverseProperty("Department")]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public Instructor Manage { get; set; }=new Instructor();
        [ForeignKey("Instructor")]
        public int?InstructorId { get; set; }
        #endregion
    }
}
