using IndivisualProjectPartB.Database;
using IndivisualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Repositories
{
    public class StudentRepository
    {
       private ApplicationDbContext context = new ApplicationDbContext();
        public void Create(Student student)
        {
          
            context.Entry(student).State = System.Data.Entity.EntityState.Added;
            context.SaveChanges();

        }

        public  List<Student> GetAll()
        {
                return   context.Students.ToList();
        
         
        
        }

        public void Edit(Student student)
        {
          
            var stu = context.Students.Find(student.Id);
            if (stu != null)
            {

                stu = student;
                context.Students.AddOrUpdate(stu);
               
               
            }
            else
            {
                Console.WriteLine($"The student with the id {student.Id} doesnt exist");
            }

        }
        public List<Student> GetAllWithAssignmentsAndCourses()
        {



            return context.Students.Include(x => x.assignments).Include(x => x.Courses).ToList();



        }
        public List<Student> GetStudentsWithMorethanOneCourse()
        {
            return context.Students.Where(x=>x.Courses.Count()>1).ToList();    
        }

        public void Dispose(int id)
        {
            Student student = context.Students.Find(id);
            if (student != null)
            {
                var students = GetAllWithAssignmentsAndCourses();
               foreach (var stu in students)
                {
                    foreach (var assignment in stu.assignments)
                    {
                        if (student.Id == assignment.studentId)
                        {
                            assignment.studentId = null;
                        }
                       
                    }
                }

              

                context.Students.Remove(student);
                context.SaveChanges();
            }
            else
                Console.WriteLine("there is no student with that id");
          
       
        }

        
      

    }
}
