using IndivisualProjectPartB.Database;
using IndivisualProjectPartB.Entities;
using IndivisualProjectPartB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace IndivisualProjectPartB.Views
{
    public class Print
    {
       
        public static void PrintObject(int number)
        {
            
            switch (number)
            {
                case 1:
                    
                    Console.WriteLine("Press 1 to print all students ,  2 to print all students with their assignments and courses, 3 to print all students that belong to more than one course");
                    int number1=int.Parse(Console.ReadLine());
                   
                    Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                    StudentRepository studentRepository = new StudentRepository();
                    Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                    var studentswithass = studentRepository.GetAllWithAssignmentsAndCourses();
                    var students = studentRepository.GetAll();
                    var studentsWithMany = studentRepository.GetStudentsWithMorethanOneCourse();
                 

                    if (number1 == 1)
                    {
                        foreach (var stu in students)
                        {
                        
                            Console.WriteLine($"{stu.Id} {stu.FirstName} {stu.LastName} {stu.DateOfBirth} {stu.TuitionFees} ");
                           
                        }

                    }
                   
                    else if (number1 == 2)
                    {
                        foreach (var stu in studentswithass)
                        {
                            Console.WriteLine($"{stu.Id}, {stu.FirstName}, {stu.LastName}, {stu.DateOfBirth}, {stu.TuitionFees}  ");
                            foreach (Assignment ass in stu.assignments)
                            {
                                Console.WriteLine($" Student ID  {stu.Id} , Assignments {ass.Id}, {ass.Description}, {ass.subDateTime}, {ass.OralMark}, {ass.TotalMark}  ");
                            }
                            foreach(Course course in stu.Courses)
                            {
                                Console.WriteLine($" Course {course.Id} {course.Title}");
                            }
                         

                        }
                      
                    }
                    else if (number1 == 3)
                    {
                        if (studentsWithMany == null)
                        {
                            Console.WriteLine("there are no students that belong to more than one course");
                        }
                        else
                            foreach(var stu in studentsWithMany)
                            {
                                Console.WriteLine($"{stu.Id} {stu.FirstName} {stu.LastName} {stu.DateOfBirth} {stu.TuitionFees} {stu.Courses.Count()} ");
                            }
                          


                    }
                    else
                        Console.WriteLine("Wrong Input");
                    
                    break;
                case 2:

                    Console.WriteLine("Press 1 to print all assignments");
                    int number2 = int.Parse(Console.ReadLine());
                    AssignmentRepository assignmentRepository = new AssignmentRepository();
                    var assignments = assignmentRepository.GetAll();
                   
                    if (number2 == 1)
                    {
                        foreach (var assignment in assignments)
                        {
                            Console.WriteLine($"{assignment.Title} {assignment.subDateTime} {assignment.Description} {assignment.OralMark} {assignment.TotalMark} ");
                        }


                    }
                 


                    break;
                case 3:
                    Console.WriteLine("Press 1 to print all courses,press 2 all assignments per course");
                    int number3 = int.Parse(Console.ReadLine());
                    CourseRepository courseRepository = new CourseRepository(); 
                    var courses = courseRepository.GetAll();
                    var coursesWithAssignments = courseRepository.GetAllWithAssignments();
                    var coursesWithTrainers = courseRepository.GetAllWithTrainers();
                    if (number3 == 1)
                    {
                        foreach(var course in courses) 
                            {
                                Console.WriteLine($"{course.Id} {course.Title} {course.Type} {course.Stream} {course.StartDate} {course.EndDate}");
                            } 
                   
                    }
                    if (number3 == 2)
                    {
                        foreach (var course in coursesWithAssignments)
                        {
                            Console.WriteLine($"{course.Id} {course.Title} {course.Type} {course.Stream} {course.StartDate} {course.EndDate}");
                            foreach(var assignment in course.Assignments)
                            {
                                Console.WriteLine($"{assignment.Title} {assignment.subDateTime} {assignment.Description} {assignment.OralMark} {assignment.TotalMark} ");
                            }
                        }
                    }
                    if(number3 == 3)
                    {
                        foreach(var course in coursesWithTrainers)
                        {
                            Console.WriteLine($"{course.Id} {course.Title} {course.Type} {course.Stream} {course.StartDate} {course.EndDate}");
                            foreach(var trainer in course.Trainers)
                            {
                                Console.WriteLine($"{trainer.ID} {trainer.FirstName} {trainer.LastName} {trainer.Subject}");
                            }
                        }
                    }
                        break;
                case 4:
                    Console.WriteLine("Press 1 to print all trainers");
                    int number4 = int.Parse(Console.ReadLine());
                    TrainerRepository trainerRepository = new TrainerRepository();
                    var trainers = trainerRepository.GetAll();
                    if (number4 == 1)
                    {
                        foreach(var trainer in trainers)
                        {
                            Console.WriteLine($"{trainer.ID} {trainer.FirstName} {trainer.LastName} {trainer.Subject}");
                        }
                    }


                    break;
                default:
                    Console.Error.WriteLine("Invalid data ");
                    break;
            }
        }

    }
}
