using IndivisualProjectPartB.Database;
using IndivisualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Repositories
{
    public class CourseRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void Create(Course course)
        {
            context.Entry(course).State = System.Data.Entity.EntityState.Added;
            context.SaveChanges();

        }

        public Course Get(int id)
        {
            var course = context.Courses.Find(id);
            return course;
        }
        public List<Course> GetAll()
        {
            return context.Courses.ToList();


        }

        public void Edit(Course course)
        {

            var cours = context.Courses.Find(course.Id);
            if (cours != null)
            {
                cours = course;
                context.Courses.AddOrUpdate(cours);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"The course with the id {course.Id} doesnt exist");
            }

        }


        public List<Course> GetAllWithAssignments()
        {

            return context.Courses.Include(x => x.Assignments).ToList();

        }
        public List<Course> GetAllWithTrainers()
        {

            return context.Courses.Include(x => x.Trainers).ToList();

        }
        public void Dispose(int id)
        {
            Course course = Get(id);
            if (course != null)
            {

                var coursest = GetAllWithTrainers();
                var coursesa = GetAllWithAssignments();
                foreach (var cour in coursesa)
                {
                    foreach (var assignment in cour.Assignments)
                    {
                        if (course.Id == assignment.CourseId)
                        {
                            assignment.CourseId = null;
                        }

                    }
                   
                }
                foreach (var cour in coursest)
                {
                    foreach (var trainer in cour.Trainers)
                    {
                        if (course.Id == trainer.CourseId)
                        {
                            trainer.CourseId = null;
                        }

                    }

                }
                context.Courses.Remove(course);
                context.SaveChanges();
            }
            else
                Console.WriteLine("there is no course with that id");
        }
        public void AddAssignment()
        {


            List<int> assignments = new List<int>();
            foreach (var assignment in context.Assignments.ToList())
            {
                if (assignment.CourseId == null)
                {
                    assignments.Add(assignment.Id);
                }

            }

            if (assignments.Count == 0)
            {
                Console.WriteLine("There are no available assignments to add to the course");
            }
            else
            {
                Console.WriteLine("Choose between these available assignments to add");
                foreach (int id in assignments)
                {
                    Console.WriteLine(id);
                }
                int assignmentid = int.Parse(Console.ReadLine());
                Console.WriteLine("type the id of the course you want the assignment to be added on");
                int courseid = int.Parse(Console.ReadLine());
                if (context.Assignments.Find(assignmentid) == null)
                {
                    Console.WriteLine("the assignment id you gave was not available");
                }
                else if (context.Assignments.Find(courseid) == null)
                {
                    Console.WriteLine("the course id you gave was not available");
                }
                else
                {
                    context.Assignments.Find(assignmentid).CourseId = courseid;
                    context.SaveChanges();
                }


            }

        }
    }
   
}
