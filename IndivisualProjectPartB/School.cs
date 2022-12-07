using IndivisualProjectPartB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB
{
    public class School
    {
        public static void Action()
        {
            int answer2;
            int x;
            do
            {
                x= 0;
                Console.WriteLine("Choose what you want to do");
                Console.WriteLine("type 1 to create , 2 to edit , 3 to read , 4 to delete, 5 to match existing properties");
                int answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {

                   
                    Console.WriteLine("1 student/2 assignment/3 course/4 trainer");
                     answer2 = int.Parse(Console.ReadLine());
                    Create.CreateObject(answer2);



                }
                else if (answer == 2)
                {

                    Console.WriteLine("1 student/2 assignment/3 course/4 trainer");
                    answer2 = int.Parse(Console.ReadLine());
                    Edit.EditObject(answer2);

                }
                else if (answer == 3)
                {

                    Console.WriteLine("1 student/2 assignment/3 course/4 trainer");
                    answer2 = int.Parse(Console.ReadLine());
                    Print.PrintObject(answer2);

                }
                else if (answer == 4)
                {

                    Console.WriteLine("1 student/2 assignment/3 course/4 trainer");
                    answer2 = int.Parse(Console.ReadLine());
                    Delete.DeleteObject(answer2);

                }
                else if (answer == 5)
                {

                    Console.WriteLine("1 student and course/2 student and asssignment/3 assignment and course/4 trainer and course");
                    answer2 = int.Parse(Console.ReadLine());
                    Match.MatchObject(answer2);

                }
                else 
                {
                    x = 2;
                   
                        Console.WriteLine("Give a valid answer");
                   
                   
                }
             }while (x==2);
            

        }
    }
}
