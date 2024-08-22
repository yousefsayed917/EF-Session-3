using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } =string.Empty;
        public string Address { get; set; } = string.Empty;
        public int? Age { get; set; }
        #region Department
        [InverseProperty("Students")]
        public Department Department { get; set; }= new Department();
        [ForeignKey("Department")]
        public int?DeptId { get; set; }
        #endregion
    }
}
