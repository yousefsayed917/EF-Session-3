using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal HourRate { get; set; }
        [Column(TypeName = "Money")]
        public decimal Salary { get; set; }
        [Column(TypeName = "Money")]
        public decimal Bouns { get; set; }
        #region Department
        [InverseProperty("Instructors")]
        public Department Department { get; set; } = new Department();
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        #endregion
    }
}
