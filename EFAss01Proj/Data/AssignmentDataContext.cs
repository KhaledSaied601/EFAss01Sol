using EFAss01Proj.Data.Configurations;
using EFAss01Proj.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFAss01Proj.Data
{
    internal class AssignmentDataContext:DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9M79TV9;Database=NewDatabase;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>(c =>
            {
                c.HasKey(nameof(Course.Id));
                c.Property<string>("Name").HasColumnType("varchar").HasMaxLength(25).IsRequired(true);

            });

            modelBuilder.ApplyConfiguration<CourseInstructor>(new CourseInstructorsConfiguration());
            modelBuilder.ApplyConfiguration<StudentCourse>(new StudentCourseConfiguration());
        }


        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<CourseInstructor> CourseInstructors { get; set; }
        DbSet<StudentCourse> StudentCourse { get; set; }



    }
}
