using Assignment.Configration;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class Iti : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = JOO;Database = ITI;Trusted_Connection = true;TrustServerCertificate = True;", x => x.UseDateOnlyTimeOnly());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TopicConfigration());
            modelBuilder.Entity<StudentCourse>().HasKey(p => new { p.StudentId, p.CourseId });
            modelBuilder.Entity<InctructorCourse>().HasKey(p => new { p.InstructorId, p.CourseId });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
