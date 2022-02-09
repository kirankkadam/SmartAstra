using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Data
{
    public class Recepient : BaseDbOperations<Entities.Recepient>
    {
        public override Entities.Recepient Delete(Entities.Recepient recepient)
        {
            var recepientToBeDeleted = AstraDbContext.Recepients.AsNoTracking().FirstOrDefault(r => r.Id == recepient.Id);
            var entity = AstraDbContext.Recepients.Remove(recepientToBeDeleted);
            return entity.Entity;
        }

        public override Entities.Recepient Get(int id)
        {
            return AstraDbContext.Recepients.AsNoTracking().FirstOrDefault(r => r.Id == id);
        }

        public override IList<Entities.Recepient> GetAll()
        {
            return AstraDbContext.Recepients.AsNoTracking().ToList();
        }

        public override Entities.Recepient Insert(Entities.Recepient recepient)
        {
            var newRecepient = AstraDbContext.Recepients.Add(recepient);
            AstraDbContext.SaveChanges();
            recepient.Id = newRecepient.Entity.Id;
            return recepient;
        }

        public override Entities.Recepient Update(Entities.Recepient recepient)
        {
            var updatedRecepient = AstraDbContext.Recepients.Update(recepient);
            return updatedRecepient.Entity;
        }
    }
}
