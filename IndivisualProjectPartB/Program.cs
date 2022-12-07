using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                School.Action();
                Console.WriteLine("type 0 if you want to end the program or anything else if you want to continue ");
                 answer =Console.ReadLine();
            }while(answer!="0");

        }
    }
}
