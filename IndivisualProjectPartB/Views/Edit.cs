using IndivisualProjectPartB.Entities;
using IndivisualProjectPartB.Enums;
using IndivisualProjectPartB.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Views
{
    public class Edit
    {
        public static void EditObject(int number)
        {
            switch (number)
            {


                case 1:
                    Console.WriteLine("Edit student");
                    Console.WriteLine("type id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("type firstName");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("type last name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("type tuitionfees");
                    int tuitionFees = int.Parse(Console.ReadLine());
                    Console.WriteLine("type date of birth");
                    DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
                    Student student = new Student()
                    {
                        Id = id,
                        FirstName=firstName,
                        LastName=lastName,
                        DateOfBirth=dateOfBirth,
                        TuitionFees=tuitionFees
                    };
                    StudentRepository studentRepository = new StudentRepository();
                    studentRepository.Edit(student);
                break;
                case 2:
                    Console.WriteLine("Edit assignment");
                    Console.WriteLine("type id");
                    int aid = int.Parse(Console.ReadLine());
                    Console.WriteLine("type title");
                    string title = Console.ReadLine();
                    Console.WriteLine("type description");
                    string description = Console.ReadLine();
                    Console.WriteLine("type oral mark");
                    int oralMark = int.Parse(Console.ReadLine());
                    Console.WriteLine("type total mark");
                    int totalMark = int.Parse(Console.ReadLine());
                    Console.WriteLine("type sumbission data time");
                    DateTime subDateTime = DateTime.Parse(Console.ReadLine());
                   
                    Assignment assignment = new Assignment()
                    {
                        Title=title,
                        Description=description,
                        OralMark=oralMark,
                        TotalMark=totalMark,
                        subDateTime= subDateTime,
                        Id=aid
                    };
                    AssignmentRepository assignmentRepository = new AssignmentRepository();
                    assignmentRepository.Edit(assignment);

                break;
                case 3:
                    Console.WriteLine("Edit course");
                    Console.WriteLine("type id");
                    int cid = int.Parse(Console.ReadLine());
                    Console.WriteLine("type stream");
                    string stream = Console.ReadLine();
                    Console.WriteLine("type course type either full time or part time");
                    string type = Console.ReadLine();
                    JobType courseType = (JobType)Enum.Parse(typeof(JobType), type, true);
                    Console.WriteLine("type start date");
                    DateTime startDate =DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("type end date");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("type course title");
                    string coursetitle = Console.ReadLine();
                    Course course = new Course()
                    {
                        Id = cid,
                        Stream = stream,
                        Type = courseType,
                        StartDate =startDate,
                        EndDate=endDate,
                        Title=coursetitle
                       
                        
                    };
                    CourseRepository courseRepository = new CourseRepository();
                    courseRepository.Edit(course);
                   
                    break;
                case 4:
                    Console.WriteLine("Edit trainer");
                    Console.WriteLine("type id");
                    int tid = int.Parse(Console.ReadLine());
                    Console.WriteLine("type first name ");
                    string tfirstName = Console.ReadLine();
                    Console.WriteLine("type last name ");
                    string tlastName = Console.ReadLine();
                    Console.WriteLine("type subject");
                    string subject = Console.ReadLine();    


                    Trainer trainer = new Trainer()
                    {
                        ID=tid,
                        FirstName=tfirstName,
                        LastName=tlastName,
                        Subject=subject
                    };
                    TrainerRepository trainerRepository = new TrainerRepository();
                    trainerRepository.Edit(trainer);


                    break;
                default:
                    Console.Error.WriteLine("Invalid data "); 
                    break;
            }
        }
    }
}
