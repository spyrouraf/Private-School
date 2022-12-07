using IndivisualProjectPartB.Database;
using IndivisualProjectPartB.Entities;
using IndivisualProjectPartB.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Views
{
    public class Match
    {
      
        public  static void MatchObject(int answer)
        {
            
            switch (answer)
            {
             
                case 1:

                    ApplicationDbContext context = new ApplicationDbContext();
                    Console.WriteLine("type the id of the course ");
                        int courseid = int.Parse(Console.ReadLine());
                        Console.WriteLine("type the id of the student");
                        int studentid = int.Parse(Console.ReadLine());
                        Student student = context.Students.Find(studentid);
                        Course course = context.Courses.Find(courseid);
                        Console.WriteLine(student.Id);
                        Console.WriteLine(course.Id);
                        if (course == null)
                        {
                            Console.WriteLine("the course id you gave does not exist");
                        }
                        else if (student == null)
                        {
                            Console.WriteLine("the student id you gave does not exist");
                        }

                        else if (context.Courses.Find(courseid).Assignments == context.Students.Find(studentid).assignments)
                        {
                            Console.WriteLine("In order to add the course to the student the student assignments and the course assignments has to be the same");
                        }

                        else
                        {
                            context.Courses.Find(courseid).Students.Add(student);

                            context.Students.Find(studentid).Courses.Add(course);
                            context.SaveChanges();
                        }


                  
                    break;
                case 2:
                       context = new ApplicationDbContext();
                     var assignments = new List<int>();
                    foreach (var assignment in context.Assignments.ToList())
                    {
                        if (assignment.CourseId == null)
                        {
                            assignments.Add(assignment.Id);
                        }

                    }



                    if (assignments.Count == 0)
                    {
                        Console.WriteLine("There are no assignments without an existing student ");
                        Console.WriteLine("If you want to go back to the menu press 0 else press anything else");
                         answer = int.Parse(Console.ReadLine());
                        if(answer == 0)
                        {
                            break;
                        }
                       
                    }


                   
                        
                        Console.WriteLine("These are the assignments with no students ");
                        foreach (int id in assignments)
                        {
                            Console.WriteLine(id);
                        }

                        int assignmentid = int.Parse(Console.ReadLine());
                            Console.WriteLine("type the id of the student ");
                             studentid = int.Parse(Console.ReadLine());
                            if (context.Assignments.Find(assignmentid) == null)
                            {
                                Console.WriteLine("the assignment id you gave was not available");
                            }
                            else if (context.Students.Find(studentid) == null)
                            {
                                Console.WriteLine("the student id you gave was not available");
                            }
                            else
                            {
                                 
                                context.Assignments.Find(assignmentid).studentId = studentid;
                             
                                context.SaveChanges();
                            }


                        

                   

                    break;
                case 3:
                    context = new ApplicationDbContext();
                     assignments = new List<int>();
                    foreach (var assignment in context.Assignments.ToList())
                    {
                        if (assignment.CourseId == null)
                        {
                            assignments.Add(assignment.Id);
                        }

                    }

                    if (assignments.Count == 0)
                    {
                        Console.WriteLine("There are no assignments without an existing student ");
                        Console.WriteLine("If you want to go back to the menu press 0 else press anything else");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 0)
                        {
                            break;
                        }

                    }

                      Console.WriteLine("These are the assignments with no courses ");
                        foreach (int id in assignments)
                        {
                            Console.WriteLine(id);
                        }
                         assignmentid = int.Parse(Console.ReadLine());
                        Console.WriteLine("type the id of the course ");
                        courseid = int.Parse(Console.ReadLine());
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


                   


                    break;
                case 4:

                     context = new ApplicationDbContext();
                    Console.WriteLine("type the id of the course ");
                     courseid  = int.Parse(Console.ReadLine());
                    Console.WriteLine("type the id of the trainer");
                    int trainerid = int.Parse(Console.ReadLine());
                    Trainer trainer = context.Trainers.Find(trainerid);
                     course = context.Courses.Find(courseid);
                    Console.WriteLine(trainer.ID);
                    Console.WriteLine(course.Id);
                    if (course == null)
                    {
                        Console.WriteLine("the course id you gave does not exist");
                    }
                    else if (trainer == null)
                    {
                        Console.WriteLine("the trainer id you gave does not exist");
                    }

                    else
                    {
                        

                        context.Trainers.Find(trainerid).CourseId=courseid;
                        context.SaveChanges();
                    }


                    break;
               
                default:
                    Console.WriteLine("Invalid Data");
                    break;
            }

        }

    }
}
