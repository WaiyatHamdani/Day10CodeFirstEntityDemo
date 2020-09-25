using Day10CodeFirstDemo.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CodeFirstDemo.Context
{
    class CourseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

    }
}
