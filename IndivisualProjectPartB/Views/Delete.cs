using IndivisualProjectPartB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Views
{
    public class Delete
    {
        public static void DeleteObject(int answer) 
            {
            switch (answer)
            {
                case 1:
                    Console.WriteLine("type the id of the student you want to be deleted");
                    int sid = int.Parse(Console.ReadLine());
                    StudentRepository studentRepository = new StudentRepository();
                    studentRepository.Dispose(sid);
                    break;

                case 2:
                    Console.WriteLine("type the id of the assignment you want to be deleted");
                    int aid = int.Parse(Console.ReadLine());
                    AssignmentRepository assignmentRepository = new AssignmentRepository();
                    assignmentRepository.Dispose(aid);

                    break;

                case 3:
                    Console.WriteLine("type the id of the course you want to be deleted");
                    int cid=int.Parse(Console.ReadLine());
                    CourseRepository courseRepository = new CourseRepository();
                    courseRepository.Dispose(cid);
                    

                    break;

                case 4:
                    Console.WriteLine("type the id of the trainer you want to be deleted");
                    int tid = int.Parse(Console.ReadLine());
                    TrainerRepository trainerRepository = new TrainerRepository();
                    trainerRepository.Dispose(tid);

                    break;

               default:
                    Console.Error.WriteLine("Invalid data ");
                    break;
            }

            } 
    }
}
