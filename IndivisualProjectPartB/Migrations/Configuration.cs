namespace IndivisualProjectPartB.Migrations
{
    using IndivisualProjectPartB.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IndivisualProjectPartB.Database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(IndivisualProjectPartB.Database.ApplicationDbContext context)
        {
            Assignment a1 = new Assignment() { Title = "t1", Description = "d1", subDateTime = new DateTime(2022, 8, 1).Date, OralMark = 71, TotalMark = 51, studentId = 1, CourseId = 1 };

            Assignment a2 = new Assignment() { Title = "t2", Description = "d2", subDateTime = new DateTime(2022, 8, 2).Date, OralMark = 72, TotalMark = 52, studentId = 1, CourseId = 1 };
            Assignment a3 = new Assignment() { Title = "t3", Description = "d3", subDateTime = new DateTime(2022, 8, 3).Date, OralMark = 73, TotalMark = 53, studentId = 2, CourseId = 1 };
            Assignment a4 = new Assignment() { Title = "t4", Description = "d4", subDateTime = new DateTime(2022, 8, 4).Date, OralMark = 74, TotalMark = 54, studentId = 2, CourseId = 1 };
            Assignment a5 = new Assignment() { Title = "t5", Description = "d5", subDateTime = new DateTime(2022, 8, 5).Date, OralMark = 75, TotalMark = 55, studentId = 3, CourseId = 2 };
            Assignment a6 = new Assignment() { Title = "t6", Description = "d6", subDateTime = new DateTime(2022, 8, 6).Date, OralMark = 76, TotalMark = 56, studentId = 3, CourseId = 2 };
            Assignment a7 = new Assignment() { Title = "t7", Description = "d7", subDateTime = new DateTime(2022, 8, 7).Date, OralMark = 77, TotalMark = 57, studentId = 4, CourseId = 2 };
            Assignment a8 = new Assignment() { Title = "t8", Description = "d8", subDateTime = new DateTime(2022, 8, 8).Date, OralMark = 78, TotalMark = 58, studentId = 4, CourseId = 2 };
            Assignment a9 = new Assignment() { Title = "t9", Description = "d9", subDateTime = new DateTime(2022, 8, 9).Date, OralMark = 79, TotalMark = 59, studentId = 5, CourseId = 3 };
            Assignment a10 = new Assignment() { Title = "t10", Description = "d10", subDateTime = new DateTime(2022, 8, 10).Date, OralMark = 80, TotalMark = 60, studentId = 5, CourseId = 3 };
            Assignment a11 = new Assignment() { Title = "t11", Description = "d11", subDateTime = new DateTime(2022, 8, 11).Date, OralMark = 81, TotalMark = 61, studentId = 6, CourseId = 3 };
            Assignment a12 = new Assignment() { Title = "t12", Description = "d12", subDateTime = new DateTime(2022, 8, 12).Date, OralMark = 82, TotalMark = 62, studentId = 6, CourseId = 3 };
            Assignment a13 = new Assignment() { Title = "t13", Description = "d13", subDateTime = new DateTime(2022, 8, 13).Date, OralMark = 83, TotalMark = 63, studentId = 7, CourseId = 4 };
            Assignment a14 = new Assignment() { Title = "t14", Description = "d14", subDateTime = new DateTime(2022, 8, 14).Date, OralMark = 84, TotalMark = 64, studentId = 7, CourseId = 4 };
            Assignment a15 = new Assignment() { Title = "t15", Description = "d15", subDateTime = new DateTime(2022, 8, 15).Date, OralMark = 85, TotalMark = 65, studentId = 8, CourseId = 4 };
            Assignment a16 = new Assignment() { Title = "t16", Description = "d16", subDateTime = new DateTime(2022, 8, 16).Date, OralMark = 86, TotalMark = 66, studentId = 8, CourseId = 4 };
            Assignment a17 = new Assignment() { Title = "t17", Description = "d17", subDateTime = new DateTime(2022, 8, 17).Date, OralMark = 87, TotalMark = 67, studentId = 9, CourseId = 5 };
            Assignment a18 = new Assignment() { Title = "t18", Description = "d18", subDateTime = new DateTime(2022, 8, 18).Date, OralMark = 88, TotalMark = 68, studentId = 9, CourseId = 5 };
            Assignment a19 = new Assignment() { Title = "t19", Description = "d19", subDateTime = new DateTime(2022, 8, 19).Date, OralMark = 89, TotalMark = 69, studentId = 10, CourseId = 5 };
            Assignment a20 = new Assignment() { Title = "t20", Description = "d20", subDateTime = new DateTime(2022, 8, 20).Date, OralMark = 90, TotalMark = 70, studentId = 10, CourseId = 5 };

            Student s1 = new Student() { FirstName = "f1", LastName = "l1", DateOfBirth = new DateTime(2003, 9, 1).Date, TuitionFees = 201 };
            Student s2 = new Student() { FirstName = "f2", LastName = "l2", DateOfBirth = new DateTime(2003, 9, 2).Date, TuitionFees = 202 };
            Student s3 = new Student() { FirstName = "f3", LastName = "l3", DateOfBirth = new DateTime(2003, 9, 3).Date, TuitionFees = 203 };
            Student s4 = new Student() { FirstName = "f4", LastName = "l4", DateOfBirth = new DateTime(2003, 9, 4).Date, TuitionFees = 204 };
            Student s5 = new Student() { FirstName = "f5", LastName = "l5", DateOfBirth = new DateTime(2003, 9, 5).Date, TuitionFees = 205 };
            Student s6 = new Student() { FirstName = "f6", LastName = "l6", DateOfBirth = new DateTime(2003, 9, 6).Date, TuitionFees = 206 };
            Student s7 = new Student() { FirstName = "f7", LastName = "l7", DateOfBirth = new DateTime(2003, 9, 7).Date, TuitionFees = 207 };
            Student s8 = new Student() { FirstName = "f8", LastName = "l8", DateOfBirth = new DateTime(2003, 9, 8).Date, TuitionFees = 208 };
            Student s9 = new Student() { FirstName = "f9", LastName = "l9", DateOfBirth = new DateTime(2003, 9, 9).Date, TuitionFees = 209 };
            Student s10 = new Student() { FirstName = "f10", LastName = "l10", DateOfBirth = new DateTime(2003, 9, 10).Date, TuitionFees = 210 };


            Course c1 = new Course() { Title = "t1", Stream = "s1", Type = Enums.JobType.PartTime, StartDate = new DateTime(2022, 8, 1).Date, EndDate = new DateTime(2022, 12, 20).Date };
            Course c2 = new Course() { Title = "t2", Stream = "s2", Type = Enums.JobType.PartTime, StartDate = new DateTime(2022, 8, 2).Date, EndDate = new DateTime(2022, 12, 21).Date };
            Course c3 = new Course() { Title = "t3", Stream = "s3", Type = Enums.JobType.Fulltime, StartDate = new DateTime(2022, 8, 3).Date, EndDate = new DateTime(2022, 12, 22).Date };
            Course c4 = new Course() { Title = "t4", Stream = "s4", Type = Enums.JobType.Fulltime, StartDate = new DateTime(2022, 8, 4).Date, EndDate = new DateTime(2022, 12, 23).Date };
            Course c5 = new Course() { Title = "t5", Stream = "s5", Type = Enums.JobType.Fulltime, StartDate = new DateTime(2022, 8, 5).Date, EndDate = new DateTime(2022, 12, 24).Date };

            Trainer t1 = new Trainer() { FirstName = "f1", LastName = "l1", Subject = "s1",CourseId=1 };
            Trainer t2 = new Trainer() { FirstName = "f2", LastName = "l2", Subject = "s2", CourseId=1 };
            Trainer t3 = new Trainer() { FirstName = "f3", LastName = "l3", Subject = "s3", CourseId = 2 };
            Trainer t4 = new Trainer() { FirstName = "f4", LastName = "l4", Subject = "s4", CourseId = 2 };
            Trainer t5 = new Trainer() { FirstName = "f5", LastName = "l5", Subject = "s5", CourseId = 3 };
            Trainer t6 = new Trainer() { FirstName = "f6", LastName = "l6", Subject = "s6", CourseId = 3 };
            Trainer t7 = new Trainer() { FirstName = "f7", LastName = "l7", Subject = "s7", CourseId = 4 };
            Trainer t8 = new Trainer() { FirstName = "f8", LastName = "l8", Subject = "s8", CourseId = 4 };
            Trainer t9 = new Trainer() { FirstName = "f9", LastName = "l9", Subject = "s9", CourseId = 5 };
            Trainer t10 = new Trainer() { FirstName = "f10", LastName = "l10", Subject = "s10", CourseId = 5 };

            s1.assignments = new List<Assignment>() { a1, a2 };
            s2.assignments = new List<Assignment>() { a3, a4 };
            s3.assignments = new List<Assignment>() { a5, a6 };
            s4.assignments = new List<Assignment>() { a7, a8 };
            s5.assignments = new List<Assignment>() { a9, a10 };
            s6.assignments = new List<Assignment>() { a11, a12 };
            s7.assignments = new List<Assignment>() { a13, a14 };
            s8.assignments = new List<Assignment>() { a15, a16 };
            s9.assignments = new List<Assignment>() { a17, a18 };
            s10.assignments = new List<Assignment>() { a19, a20 };
           
            s1.Courses = new List<Course>() { c1,c5 };
            s2.Courses = new List<Course>() { c1 };
            s3.Courses = new List<Course>() { c2 };
            s4.Courses = new List<Course>() { c2 };
            s5.Courses = new List<Course>() { c3 };
            s6.Courses = new List<Course>() { c3 };
            s7.Courses = new List<Course>() { c4 };
            s8.Courses = new List<Course>() { c4 };
            s9.Courses = new List<Course>() { c5 };
            s10.Courses = new List<Course>() { c5 };
            
            

            c1.Students = new List<Student>() { s1, s2 };
            c2.Students = new List<Student>() { s3, s4 };
            c3.Students = new List<Student>() { s5, s6 };
            c4.Students = new List<Student>() { s7, s8 };
            c5.Students = new List<Student>() { s9, s10,s1 };

            c1.Assignments = new List<Assignment>() { a1, a2, a3, a4 };
            c2.Assignments = new List<Assignment>() { a5, a6, a7, a8 };
            c3.Assignments = new List<Assignment>() { a9, a10, a11, a12 };
            c4.Assignments = new List<Assignment>() { a13, a12, a13, a14 };
            c5.Assignments = new List<Assignment>() { a17, a18, a19, a20 };

            c1.Trainers = new List<Trainer>() { t1, t2 };
            c2.Trainers = new List<Trainer>() { t3, t4 };
            c3.Trainers = new List<Trainer>() { t5, t6 };
            c4.Trainers = new List<Trainer>() { t7, t8 };
            c5.Trainers = new List<Trainer>() { t9, t10 };


           
       





            context.Students.AddOrUpdate( s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);



            context.Trainers.AddOrUpdate(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);


            context.Assignments.AddOrUpdate(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20);


            context.Courses.AddOrUpdate(c1, c2, c3, c4, c5);






            context.SaveChanges();

        }
    }
}
