using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Data
{
    public class User : BaseDbOperations<Entities.User>
    {
        public override Entities.User Delete(Entities.User user)
        {
            var existingUser = AstraDbContext.Users.AsNoTracking().FirstOrDefault(u=> u.Id== user.Id);
            if (existingUser != null)
            {
                var deletedEntity = AstraDbContext.Users.Remove(existingUser);
                return deletedEntity.Entity;
            }

            return null;
        }

        public override Entities.User Get(int id)
        {
            return AstraDbContext.Users.AsNoTracking().FirstOrDefault(u => u.Id == id);
        }

        public override IList<Entities.User> GetAll()
        {
            return AstraDbContext.Users.AsNoTracking().ToList();
        }

        public override Entities.User Insert(Entities.User newUser)
        {
            var user = AstraDbContext.Users.Add(newUser);
            newUser.Id = user.Entity.Id;
            return newUser;
        }

        public override Entities.User Update(Entities.User existingUser)
        {
            var user = AstraDbContext.Users.AsNoTracking().FirstOrDefault(u => u.Id == existingUser.Id);
            user = existingUser;
            var updatedEntity = AstraDbContext.Users.Update(user);
            return updatedEntity.Entity;
        }
    }
}
