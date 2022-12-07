using IndivisualProjectPartB.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Entities
{
    public class Course
    {
       

        public int Id { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public JobType Type { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

       
        public ICollection<Student> Students { get; set; } 
        public ICollection<Trainer> Trainers { get; set; } 
        public ICollection<Assignment> Assignments { get; set; }
       






    }
}
