using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Data
{
    public class Message : BaseDbOperations<Entities.Message>
    {
        public override Entities.Message Delete(Entities.Message entity)
        {
            var message = AstraDbContext.Messages.AsNoTracking().FirstOrDefault(m => m.Id == entity.Id);
            if (message != null)
            {
                AstraDbContext.Messages.Remove(message);
            }
            return message;
        }

        public override Entities.Message Get(int id)
        {
            return AstraDbContext.Messages.AsNoTracking().FirstOrDefault(m => m.Id == id);
        }

        public override IList<Entities.Message> GetAll()
        {
            return AstraDbContext.Messages.AsNoTracking().ToList();
        }

        public override Entities.Message Insert(Entities.Message newMessage)
        {
            var message = AstraDbContext.Messages.Add(newMessage);
            return message.Entity;
        }

        public override Entities.Message Update(Entities.Message entity)
        {
            var message = AstraDbContext.Messages.AsNoTracking().FirstOrDefault(m => m.Id == entity.Id);
            if (message != null)
            {
                message = entity;
                AstraDbContext.Messages.Update(message);
            }
            return message;
        }
    }
}
