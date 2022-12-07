using IndivisualProjectPartB.Database;
using IndivisualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IndivisualProjectPartB.Repositories
{
    public class TrainerRepository
    {
        private ApplicationDbContext context=new ApplicationDbContext();
        public void Create(Trainer trainer)
        {
            context.Entry(trainer).State= System.Data.Entity.EntityState.Added;
            context.SaveChanges();

        }

        public Trainer Get(int id)
        {
            var trainer = context.Trainers.Find(id);
            return trainer;
        }
        public List<Trainer> GetAll()
        {
               return context.Trainers.ToList();
                
            
        }

        public void Edit(Trainer trainer)
        {
          
                var trai = context.Trainers.Find(trainer.ID);
                if (trai!=null )
                {
                    trai = trainer;
                    context.Trainers.AddOrUpdate(trai);
                    context.SaveChanges();
                }
                else
                {
                Console.WriteLine($"The trainer with the id {trainer.ID} doesnt exist");
                }
           
        }

        public void Dispose(int id)
        {
            Trainer trainer = Get(id);
            if (trainer != null)
            {
                context.Trainers.Remove(trainer);
                context.SaveChanges();
            }
            else
                Console.WriteLine("there is no trainer with that id");
        }


    }
}
