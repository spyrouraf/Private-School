using IndivisualProjectPartB.Database;
using IndivisualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Repositories
{
    public class AssignmentRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public  void Create(Assignment assignment)
        {
            context.Entry(assignment).State = System.Data.Entity.EntityState.Added;
            context.SaveChanges();

        }

        public Assignment Get(int id)
        {
            var assignment = context.Assignments.Find(id);
            return assignment;
        }
        public List<Assignment> GetAll()
        {
            return context.Assignments.ToList();


        }

        public void Edit(Assignment assignment)
        {

            var assign = context.Assignments.Find(assignment.Id);
            if (assign != null)
            {
                assign = assignment;
                context.Assignments.AddOrUpdate(assign);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"The assignement with the id {assignment.Id} doesnt exist");
            }

        }

        public void Dispose(int id)
        {
            Assignment assignment = Get(id);
            if (assignment != null)
            {
                context.Assignments.Remove(assignment);
                context.SaveChanges();
            }
            else
                Console.WriteLine("there is no assignment with that id");
        }


    }
}
