using Assignment.Context;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Iti dbcontext = new Iti();
            var result = (from a in dbcontext.Departments.Include(e => e.Instructors)
                          where a.DeptId == 5
                          select a.Manager).FirstOrDefault();
            Console.WriteLine(result?.Name ?? "not dound");
            //var result = (from a in dbcontext.Instructors
            //              where a.Id == 1
            //              select a.Manage).FirstOrDefault();
            //Console.WriteLine(result?.Name??"not dound");
        }
    }
}
