﻿using ContosoUniversity.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var students = new Student[]
            {
            new Student{ID=1,FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{ID=2,FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{ID=3,FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{ID=4,FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{ID=5,FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{ID=6,FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{ID=7,FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{ID=8,FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            modelBuilder.Entity<Student>().HasData(students);

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            modelBuilder.Entity<Course>().HasData(courses);

            var enrollments = new Enrollment[]
            {
            new Enrollment{EnrollmentID=1,StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{EnrollmentID=2,StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{EnrollmentID=3,StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{EnrollmentID=4,StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{EnrollmentID=5,StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{EnrollmentID=6,StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{EnrollmentID=7,StudentID=3,CourseID=1050},
            new Enrollment{EnrollmentID=8,StudentID=4,CourseID=1050},
            new Enrollment{EnrollmentID=9,StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{EnrollmentID=10,StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{EnrollmentID=11,StudentID=6,CourseID=1045},
            new Enrollment{EnrollmentID=12,StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            modelBuilder.Entity<Enrollment>().HasData(enrollments);
        }
    }
}
