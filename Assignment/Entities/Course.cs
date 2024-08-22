using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Duration {  get; set; } = string.Empty;
        #region Topic
        [InverseProperty("Courses")]
        public Topic Topic { get; set; }=new Topic();
        [ForeignKey("topic")]
        public int? TopicId {  get; set; } 
        #endregion
    }
}
