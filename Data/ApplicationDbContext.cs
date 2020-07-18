using System;
using System.Collections.Generic;
using System.Text;
using CollegeApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollegeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student>Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<CourseStudent> CourseStudents { get; set; }

    }
}
