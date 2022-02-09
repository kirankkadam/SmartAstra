using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Data
{
    public class Schedule : BaseDbOperations<Entities.Schedule>
    {
        public override Entities.Schedule Delete(Entities.Schedule schedule)
        {
            var scheduleToBeDeleted = AstraDbContext.Schedules.AsNoTracking().FirstOrDefault(s => s.Id == schedule.Id);
            if (scheduleToBeDeleted != null)
            {
                AstraDbContext.Schedules.Remove(scheduleToBeDeleted);
            }
            return scheduleToBeDeleted;
        }

        public override Entities.Schedule Get(int id)
        {
            return AstraDbContext.Schedules.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }

        public override IList<Entities.Schedule> GetAll()
        {
            return AstraDbContext.Schedules.AsNoTracking().ToList();
        }

        public override Entities.Schedule Insert(Entities.Schedule schedule)
        {
            var newSchedule = AstraDbContext.Schedules.Add(schedule);
            schedule.Id = newSchedule.Entity.Id;
            return schedule;
        }

        public override Entities.Schedule Update(Entities.Schedule existingSchedule)
        {
            var existingEntity = AstraDbContext.Schedules.AsNoTracking().FirstOrDefault(s=> s.Id == existingSchedule.Id);
            if (existingEntity != null)
            {
                existingEntity = existingSchedule;
                AstraDbContext.Schedules.Update(existingEntity);
            }

            return existingEntity;
        }
    }
}
