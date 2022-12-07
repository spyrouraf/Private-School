using IndivisualProjectPartB.Database;
using IndivisualProjectPartB.Entities;
using IndivisualProjectPartB.Enums;
using IndivisualProjectPartB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Views
{
    public class Create
    {
        public static void CreateObject(int number)
        {
            
            switch (number)
            {
                
                case 1:
                   
                    Console.WriteLine("Input Name");
                    string stufirstName = Console.ReadLine();
                    Console.WriteLine("Input LastName");
                    string stulastName = Console.ReadLine();
                    Console.WriteLine("Input Date of Birth  dd  /  mm/  yy leaving spaces through days month and year");
                    DateTime studateOfBirth = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Input Tuition Fees");
                    int tuitionFees = int.Parse(Console.ReadLine());
                    Student student = new Student()
                    {
                        FirstName = stufirstName,
                        LastName = stulastName,
                        DateOfBirth = studateOfBirth,
                        TuitionFees=tuitionFees
                    };

                    StudentRepository studentRepository = new StudentRepository();
                    studentRepository.Create(student);


                    break;

                case 2:
                    Console.WriteLine("Title");
                    string assignTitle = Console.ReadLine();
                    Console.WriteLine("Description");
                    string description = Console.ReadLine();
                    Console.WriteLine("Submission Date dd  /  mm/  yy leaving spaces through days month and year");
                    DateTime subDateTime = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Oral Mark");
                    int oralMark = int.Parse(Console.ReadLine());
                    Console.WriteLine("Total Mark");
                    int totalMark = int.Parse(Console.ReadLine());
                    Assignment assignment = new Assignment()
                    {
                        Title = assignTitle,
                        Description = description,
                        subDateTime = subDateTime,
                        OralMark =  oralMark,
                        TotalMark = totalMark

                    };

                    AssignmentRepository assignmentRepository = new AssignmentRepository();
                    assignmentRepository.Create(assignment);



                    break;
                case 3:
                    Console.WriteLine("Title");
                    string courseTitle = Console.ReadLine();
                    Console.WriteLine("Stream");
                    string stream = Console.ReadLine();
                    Console.WriteLine("Type choose between Fulltime and PartTime");
                    string type = Console.ReadLine();
                    JobType courseType = (JobType)Enum.Parse(typeof(JobType), type, true);
                    Console.WriteLine("Start Date dd  /  mm/  yy leaving spaces through days month and year");
                    DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("End Date dd  /  mm/  yy leaving spaces through days month and year");
                    DateTime endDate = Convert.ToDateTime(Console.ReadLine());

                    Course course = new Course()
                    {
                        Title = courseTitle,
                        Stream=stream,
                        Type=courseType,
                        StartDate= startDate,
                        EndDate= endDate

                    };
                    CourseRepository courseRepository = new CourseRepository();
                    courseRepository.Create(course);

                    break;
                case 4:
                    Console.WriteLine("Trainer's Name");
                    string tFirstName  = Console.ReadLine();
                    Console.WriteLine("Trainer's Surname");
                    string tLastName = Console.ReadLine();
                    Console.WriteLine("Trainer's subject");
                    string subject = Console.ReadLine();
                   
                    Trainer trainer = new Trainer()
                    {
                        FirstName=tFirstName,
                        LastName=tLastName,
                        Subject=subject
                    };
                    TrainerRepository trainerRepository = new TrainerRepository();
                    trainerRepository.Create(trainer);

                    break;


                default:
                    Console.Error.WriteLine("Invalid data ");
                    break;

            }

        }

    }
}
