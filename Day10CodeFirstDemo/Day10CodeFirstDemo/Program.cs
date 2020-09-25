using Day10CodeFirstDemo.Context;
using Day10CodeFirstDemo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CourseContext())
            {
                Course course = new Course()
                {
                    Id = 1,
                    Name="CodeFirst",
                    Teacher="KarlHuff",
                    Description="class about data access c sharp"

                };

                context.Courses.Add(course);
                context.SaveChanges();
            }
        }
    }
}
