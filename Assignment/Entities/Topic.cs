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
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        #region Course
        [InverseProperty("Topic")]
        public ICollection<Course> Courses { get; set; }=new HashSet<Course>();
        

        #endregion
    }
}
