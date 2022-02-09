using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Data
{
    public class Subscription : BaseDbOperations<Entities.SubscriptionPlan>
    {
        public override Entities.SubscriptionPlan Delete(Entities.SubscriptionPlan entity)
        {
            var entityToBeDeleted = AstraDbContext.Subscriptions.AsNoTracking().FirstOrDefault(s => s.Id == entity.Id);
            if (entityToBeDeleted != null)
            {
                var deletedEntity = AstraDbContext.Subscriptions.Remove(entityToBeDeleted);
                entity = deletedEntity.Entity;
            }
            return entity;
        }

        public override Entities.SubscriptionPlan Get(int id)
        {
            return AstraDbContext.Subscriptions.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }

        public override IList<Entities.SubscriptionPlan> GetAll()
        {
            return AstraDbContext.Subscriptions.AsNoTracking().ToList();
        }

        public override Entities.SubscriptionPlan Insert(Entities.SubscriptionPlan entity)
        {
            var newEntity = AstraDbContext.Subscriptions.Add(entity);
            entity = newEntity?.Entity;
            return entity;
        }

        public override Entities.SubscriptionPlan Update(Entities.SubscriptionPlan entity)
        {
            var existingSubscription = AstraDbContext.Subscriptions.AsNoTracking().FirstOrDefault(s => s.Id == entity.Id);
            if (existingSubscription != null)
            {
                existingSubscription = entity;
                AstraDbContext.Subscriptions.Update(existingSubscription);
            }
            return existingSubscription;
        }
    }
}
