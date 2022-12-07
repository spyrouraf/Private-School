using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Entities
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime subDateTime { get; set; }
        public string Title { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public Course Course { get; set; }

        public int? CourseId { get; set; }
       

        public Student Student { get; set; }
        public int? studentId { get; set; }



    }
}
